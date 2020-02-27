using System;
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Microsoft.Spatial;
using Newtonsoft.Json;

namespace demo_search.Models
{
    public partial class Content
    {
        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string Departamento { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string DisciplinaHigienizada { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string CodigoDisciplina { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string NomeDisciplina { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string Unidade { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string CompetenciaHabilidade { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string ProdutoAprendizagem { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string Secao { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string Classificacao { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string Conteudo { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string NomeDoMaterial { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string DataProdAnt { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string DataProdNov { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string TipoDoMD { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        public string Priorizacao { get; set; }

        [IsRetrievable(true)]
        [IsFilterable]
        [IsSortable]
        [IsSearchable]
        [System.ComponentModel.DataAnnotations.Key]
        public string MetadataId { get; set; }
    }
}
