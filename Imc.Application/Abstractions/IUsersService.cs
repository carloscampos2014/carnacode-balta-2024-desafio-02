﻿using Imc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Application.Abstractions;
public interface IUsersService
{
    Task<bool> AddUser(CreateUserVm model);
}
