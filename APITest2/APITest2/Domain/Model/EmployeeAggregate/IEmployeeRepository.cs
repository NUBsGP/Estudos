﻿using APITest2.Domain.DTOs;

namespace APITest2.Domain.Model.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);
        List<EmployeeDTO> Get();

        Employee? Get(int id);
    }
}