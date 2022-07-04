﻿using AutoMapper;
using SNews.BusinessLogic.Interfaces;
using SNews.BusinessModel;
using SNews.BusinessModel.Author;
using SNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.BusinessLogic
{
    public class AuthorBusinessLogic : IAuthorBusinessLogic
    {
        private readonly IMapper _mapper;
        private readonly IAuthorService _authorService;

        public AuthorBusinessLogic(IMapper mapper, IAuthorService authorService)
        {
            _mapper = mapper;
            _authorService = authorService;
        }
        public CommandResponse<Author> InsertAuthor(InsertAuthorRequest author)
        {
            CommandResponse<Author> result = new CommandResponse<Author>();

            try
            {
                var requestDM = _mapper.Map<DataModel.Author.InsertAuthorRequest>(author);
                var authorDM = _authorService.InsertAuthor(requestDM);
                if (authorDM != null)
                {
                    result.Data = _mapper.Map<Author>(authorDM);
                }
                else
                {
                    result.ErrorMessage = Resources.Resources.errServiceError;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = Resources.Resources.generalError;
                //todo log error
            }
            return result;
        }
    }
}
