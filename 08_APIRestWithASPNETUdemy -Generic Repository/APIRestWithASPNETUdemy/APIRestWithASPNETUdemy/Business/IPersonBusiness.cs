﻿using APIRestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace APIRestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
    }
}
