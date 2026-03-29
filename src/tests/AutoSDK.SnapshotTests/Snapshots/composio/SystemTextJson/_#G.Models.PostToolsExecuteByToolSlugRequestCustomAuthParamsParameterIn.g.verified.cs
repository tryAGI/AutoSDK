//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The location of the parameter. Can be 'query' or 'header'.
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn
    {
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Header => "header",
                PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn? ToEnum(string value)
        {
            return value switch
            {
                "header" => PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Header,
                "query" => PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Query,
                _ => null,
            };
        }
    }
}