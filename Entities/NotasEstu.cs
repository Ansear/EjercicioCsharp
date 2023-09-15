namespace EjercicioCsharp.Entities;

    public class NotasEstu
    {
        private List<float> quices = new List<float>{0,0,0,0};
        private List<float> trabajos = new List<float>{0,0};
        private List<float> parciales = new List<float>{0,0,0};
        public List<float> Quices{
            get{ return quices;}
            set{ quices = value;}
        }
        public List<float> Trabajos{
            get{ return trabajos;}
            set{ trabajos = value;}
        }
        public List<float> Parciales{
            get{ return parciales;}
            set{ parciales = value;}
        }

        public NotasEstu()
        {

        }
        public NotasEstu(List<float> quices, List<float> trabajos,List<float> parciales)
        {
            this.quices = quices;
            this.trabajos = trabajos;
            this.parciales = parciales;
        }
    }
