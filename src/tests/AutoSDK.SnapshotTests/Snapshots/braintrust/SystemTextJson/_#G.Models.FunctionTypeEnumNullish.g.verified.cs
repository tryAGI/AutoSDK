//HintName: G.Models.FunctionTypeEnumNullish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionTypeEnumNullish
    {
        /// <summary>
        /// 
        /// </summary>
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        CustomView,
        /// <summary>
        /// 
        /// </summary>
        Facet,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Parameters,
        /// <summary>
        /// 
        /// </summary>
        Preprocessor,
        /// <summary>
        /// 
        /// </summary>
        Sandbox,
        /// <summary>
        /// 
        /// </summary>
        Scorer,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Task,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionTypeEnumNullishExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionTypeEnumNullish value)
        {
            return value switch
            {
                FunctionTypeEnumNullish.Classifier => "classifier",
                FunctionTypeEnumNullish.CustomView => "custom_view",
                FunctionTypeEnumNullish.Facet => "facet",
                FunctionTypeEnumNullish.Llm => "llm",
                FunctionTypeEnumNullish.Parameters => "parameters",
                FunctionTypeEnumNullish.Preprocessor => "preprocessor",
                FunctionTypeEnumNullish.Sandbox => "sandbox",
                FunctionTypeEnumNullish.Scorer => "scorer",
                FunctionTypeEnumNullish.Tag => "tag",
                FunctionTypeEnumNullish.Task => "task",
                FunctionTypeEnumNullish.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionTypeEnumNullish? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => FunctionTypeEnumNullish.Classifier,
                "custom_view" => FunctionTypeEnumNullish.CustomView,
                "facet" => FunctionTypeEnumNullish.Facet,
                "llm" => FunctionTypeEnumNullish.Llm,
                "parameters" => FunctionTypeEnumNullish.Parameters,
                "preprocessor" => FunctionTypeEnumNullish.Preprocessor,
                "sandbox" => FunctionTypeEnumNullish.Sandbox,
                "scorer" => FunctionTypeEnumNullish.Scorer,
                "tag" => FunctionTypeEnumNullish.Tag,
                "task" => FunctionTypeEnumNullish.Task,
                "tool" => FunctionTypeEnumNullish.Tool,
                _ => null,
            };
        }
    }
}