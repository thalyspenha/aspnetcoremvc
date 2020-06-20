﻿namespace GerenciadorCondominio.BLL.Models
{
    public class HistoricoRecurso
    {
        public int HistoricoRecursoId { get; set; }
        public decimal Valor { get; set; }
        public int Dia { get; set; }
        public int MesId { get; set; }
        public virtual Mes Mes { get; set; }
        public int Ano { get; set; }
        public Tipos Tipo { get; set; }
    }

    public enum Tipos
    {
        Entrada,
        Saida
    }
}
