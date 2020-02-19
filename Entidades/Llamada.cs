namespace TestDotnet.Entidades
{
    public abstract class Llamada
    {
        private string numeroOrigen;
        public string NumeroOrigen
        {
            get { return numeroOrigen; }
            set { numeroOrigen = value; }
        }
        private string numeroDestino;
        public string NumeroDestino
        {
            get { return numeroDestino; }
            set { numeroDestino = value; }
        }
        private double duracion;
        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public abstract double CalcularPrecio();
        public override string ToString()
        {
            return $"{this.NumeroOrigen} - {this.NumeroDestino} - {this.Duracion}";
        }
    }
}