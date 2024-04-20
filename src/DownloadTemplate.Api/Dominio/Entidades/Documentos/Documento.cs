using DownloadTemplate.Api.Dominio.Entidades.TiposDocumentos;

namespace DownloadTemplate.Api.Dominio.Entidades.Documento
{
    public class Documento
    {
        public Guid DocumentoId { get; set; }
        public Guid TipoDocumentoId { get; set; }
        public string? Descricao { get; set; }
        public TipoDocumento? TipoDocumento { get; set; }
    }
}