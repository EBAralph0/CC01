using CC01.BO;
using CC01.BLL;
using System;
using CC01.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.DAL;

namespace CC01.BLL
{
    public class EtudiantBLO
    {
        EtudiantDAO etudiantRepo;
        private Etudiant oldEtudiant;

        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }
        public void CreateProduct(Etudiant etudiant)
        {
            etudiantRepo.Add(etudiant);
        }

        public void DeleteProduct(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }


        public IEnumerable<Etudiant> GetAllProducts()
        {
            return etudiantRepo.Find();
        }


        public IEnumerable<Etudiant> GetByReference(string matricule)
        {
            return etudiantRepo.Find(x => x.Matricule == matricule);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditProduct(Etudiant oldProduct, Etudiant newEtudiant)
        {
            etudiantRepo.Set(oldEtudiant, newEtudiant);
        }
    }
}
