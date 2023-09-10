namespace EjercicioCsharp.Entities;

    public class NotasEstu
    {
        private string idEstudiante;
        private List<float> quices = new List<float>(4);
        private List<float> trabajos = new List<float>(2);
        private List<float> parciales = new List<float>(3);
        public string IdEstudiante{
            get{ return idEstudiante;}
            set{ idEstudiante = value;}
        }
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
        public NotasEstu(string idEstudiante,List<float> quices, List<float> trabajos,List<float> parciales)
        {
            this.idEstudiante = idEstudiante;
            this.quices = quices;
            this.trabajos = trabajos;
            this.parciales = parciales;
        }
    }
