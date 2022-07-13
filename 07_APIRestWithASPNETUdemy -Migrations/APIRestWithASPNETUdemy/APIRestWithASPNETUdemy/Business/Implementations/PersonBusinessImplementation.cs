﻿using APIRestWithASPNETUdemy.Model;
using APIRestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIRestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        //----------------------------------------------------------------------------------
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        //----------------------------------------------------------------------------------
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }
        //----------------------------------------------------------------------------------

        public Person Create(Person person)
        {
            
            return _repository.Create(person);
        }
        //----------------------------------------------------------------------------------
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
        //----------------------------------------------------------------------------------
        public void Delete(long id)
        {
            _repository.Delete(id);


        }

        //----------------------------------------------------------------------------------

       
    }
}
