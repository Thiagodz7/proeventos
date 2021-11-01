import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  public eventos: any=[];
  widthImg: number = 80;
  heightImg: number = 80;
  marginImg: number = 2;
  mostrarImagem: boolean = false;
  private _filtroLista: string = '';
  public eventosFiltrados:any=[];

  public get filtroLista(): string{
    return this._filtroLista;
  }
  public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.FiltrarEventos(this.filtroLista):this.eventos
  }

public FiltrarEventos(filtrarPor: string): any{
filtrarPor= filtrarPor.toLocaleLowerCase();
return this.eventos.filter
(
  (evento:{tema: string;local:string}) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
);
}

  constructor(private http: HttpClient) { }

  public getEventos(): void{
  this.http.get('https://localhost:5001/api/Evento').subscribe(
    Response => {
      this.eventos = Response;
      this.eventosFiltrados = Response;
    },
    error => console.log(error)
  );
 }

 public AlterarImagem(){
   this.mostrarImagem=!this.mostrarImagem;
 }


  ngOnInit(): void {
    this.getEventos();
  }

}
