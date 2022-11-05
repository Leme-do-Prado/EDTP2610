class Lote{
    int id;
    int qtde;
    DateTime vencimento;

    Lote(int i, int q, DateTime v){
        this.id = i;
        this.qtde = q;
        this.vencimento = v;
    } 

    string toString(){
        return this.id + "-" + this.qtde + "-" + this.vencimento
           }
}
