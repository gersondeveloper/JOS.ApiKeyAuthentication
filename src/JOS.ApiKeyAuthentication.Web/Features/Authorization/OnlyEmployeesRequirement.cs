﻿using Microsoft.AspNetCore.Authorization;

namespace JOS.ApiKeyAuthentication.Web.Features.Authorization
{
    public class OnlyEmployeesRequirement : IAuthorizationRequirement
    {
    }
}
