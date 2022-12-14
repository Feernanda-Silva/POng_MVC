using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AnimalController
    {
        private AnimalService animalService;

        public AnimalController()
        {
            this.animalService = new AnimalService();
        }
        public void Cadastrar(Animal animal)
        {
            animalService.Cadastrar(animal);    
        }

        public Animal Consultar(int chip)
        {
            return animalService.Consultar(chip);
        }

        public void EditarRaca(string raca, int chip)
        {
            animalService.EditarRaca(raca, chip);   
        }


        public void EditarSexo(char sexo, int chip)
        {
            animalService.EditarSexo(sexo, chip);
        }

        public void EditarNomeAnimal(string nome, int chip)
        {
            animalService.EditarNomeAnimal(nome, chip);
        }

        public void EditarCodFamilia(int codFamilia, int chip)
        {
            animalService.EditarCodFamilia(codFamilia, chip);
        }

        public void Adotar(int chip, string cpf)
        {
            animalService.Adotar(chip, cpf);
        }

        public  List<Animal> ConsultarAdocao(string cpf)
        {
            return animalService.ConsultarAdocao(cpf);
        }

        public bool PossuirChipCadastrado(int chip)
        {
            return animalService.PossuirChipCadastrado(chip);
        }
    }
}
