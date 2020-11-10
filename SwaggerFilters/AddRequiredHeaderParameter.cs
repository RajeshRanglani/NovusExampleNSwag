using NSwag;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using System;

namespace NovusExampleNSwag.SwaggerFilters
{
    public class AddRequiredHeaderParameter2 : IOperationProcessor
    {
        public bool Process(OperationProcessorContext context)
        {
            throw new System.NotImplementedException();
        }
    }


    public class AddRequiredHeaderParameter : IOperationProcessor
    {
        public bool Process(OperationProcessorContext context)
        {
            context.OperationDescription.Operation.Parameters.Add(
            new OpenApiParameter
            {
                Name = "token",
                Kind = OpenApiParameterKind.Header,
                Schema = new NJsonSchema.JsonSchema() { Type=NJsonSchema.JsonObjectType.String},
                IsRequired = true,
                Description = "Bearer token for accessing Novus API"
            }); ;
            return true;
        }
    }

}
