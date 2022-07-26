import { Component } from "@angular/core";

@Component({
    selector: 'app-nova-transferencia',
    templateUrl:'./nova-transferencia.component.html',
    styleUrls: ['./nova-transferencia.component.scss']
})

export class NovaTranferenciaComponent{

  valor: number;
  destino: number;

  transferir(){
    console.log('Solicitada nova transferência');
    console.log('Valor: ', this.valor);
    console.log('Destino: ', this.destino);
  }
}
