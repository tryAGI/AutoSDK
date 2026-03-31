//HintName: G.Models.FunctionTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of global function. Defaults to 'scorer'.<br/>
    /// Default Value: scorer
    /// </summary>
    public enum FunctionTypeEnum
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
    public static class FunctionTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionTypeEnum value)
        {
            return value switch
            {
                FunctionTypeEnum.Classifier => "classifier",
                FunctionTypeEnum.CustomView => "custom_view",
                FunctionTypeEnum.Facet => "facet",
                FunctionTypeEnum.Llm => "llm",
                FunctionTypeEnum.Parameters => "parameters",
                FunctionTypeEnum.Preprocessor => "preprocessor",
                FunctionTypeEnum.Sandbox => "sandbox",
                FunctionTypeEnum.Scorer => "scorer",
                FunctionTypeEnum.Tag => "tag",
                FunctionTypeEnum.Task => "task",
                FunctionTypeEnum.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => FunctionTypeEnum.Classifier,
                "custom_view" => FunctionTypeEnum.CustomView,
                "facet" => FunctionTypeEnum.Facet,
                "llm" => FunctionTypeEnum.Llm,
                "parameters" => FunctionTypeEnum.Parameters,
                "preprocessor" => FunctionTypeEnum.Preprocessor,
                "sandbox" => FunctionTypeEnum.Sandbox,
                "scorer" => FunctionTypeEnum.Scorer,
                "tag" => FunctionTypeEnum.Tag,
                "task" => FunctionTypeEnum.Task,
                "tool" => FunctionTypeEnum.Tool,
                _ => null,
            };
        }
    }
}