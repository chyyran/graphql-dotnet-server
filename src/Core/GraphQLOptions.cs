using GraphQL.Conversion;
using GraphQL.Execution;
using GraphQL.Introspection;
using GraphQL.Validation.Complexity;
using System;

namespace GraphQL.Server
{
    public class GraphQLOptions
    {
        public ComplexityConfiguration ComplexityConfiguration { get; set; }

        /// <summary>
        /// This setting essentially allows Apollo Tracing.
        /// </summary>
        public bool EnableMetrics { get; set; } = true;

        public bool ExposeExceptions { get; set; }

        public IFieldNameConverter FieldNameConverter { get; set; }

        public Action<UnhandledExceptionContext> UnhandledExceptionDelegate = ctx => { };

        public ISchemaFilter SchemaFilter { get; set; } = new DefaultSchemaFilter();
    }
}
