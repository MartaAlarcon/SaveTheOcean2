using SaveTheOcean2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.Persistence.DAO
{
    public interface IAnimalDAO
    {
        AnimalDTO GetAnimalById(int id);
        IEnumerable<AnimalDTO> GetAllAnimals();
        void AddAnimal(AnimalDTO animal);
    }
}
