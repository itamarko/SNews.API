﻿using SNews.BusinessModel;
using SNews.BusinessModel.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.BusinessLogic.Interfaces
{
    public interface IAuthorBusinessLogic
    {
        CommandResponse<Author> InsertAuthor(InsertAuthorRequest author);
    }
}
