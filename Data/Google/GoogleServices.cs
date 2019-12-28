﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Data.Google
{
    public static class GoogleServices
    {
        public static SheetsService GetSheetsService(UserCredential credential, string applicationName)
        {
            // Create the service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            return service;
        }
    }
}
