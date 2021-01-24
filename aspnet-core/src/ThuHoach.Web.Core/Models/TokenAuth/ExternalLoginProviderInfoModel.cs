﻿using Abp.AutoMapper;
using ThuHoach.Authentication.External;

namespace ThuHoach.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
