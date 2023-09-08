namespace EjercicioCsharp.Entities;

    public class NotasEstu
    {
        private string idEstudiante;
        private List<int> quices = new List<int>(4);
        private List<int> trabajos = new List<int>(2);
        private List<int> parciales = new List<int>(3);
        public string IdEstudiante{
            get{ return idEstudiante;}
            set{ idEstudiante = value;}
        }
        public List<int> Quices{
            get{ return quices;}
            set{ quices = value;}
        }
        public List<int> Trabajos{
            get{ return trabajos;}
            set{ trabajos = value;}
        }
        public List<int> Parciales{
            get{ return parciales;}
            set{ parciales = value;}
        }

        public NotasEstu()
        {

        }
        public NotasEstu(string idEstudiante,List<int> quices, List<int> trabajos,List<int> parciales)
        {
            this.idEstudiante = idEstudiante;
            this.quices = quices;
            this.trabajos = trabajos;
            this.parciales = parciales;
        }
    }
