﻿using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.SwaggerGen
{
    public interface ISchemaRegistry
    {
        OpenApiSchema GetOrRegister(Type type, Enum enumDefaultValue = null);

        IDictionary<string, OpenApiSchema> Schemas { get; }
    }
}
