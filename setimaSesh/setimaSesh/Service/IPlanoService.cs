using setimaSesh.Model;

namespace setimaSesh.Service
{
    public interface IPlanoService
    {
        public Task<List<PlanoModel>> GetListaPlanos();
    }
}
