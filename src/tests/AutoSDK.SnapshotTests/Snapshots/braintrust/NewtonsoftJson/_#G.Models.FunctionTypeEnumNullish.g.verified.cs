//HintName: G.Models.FunctionTypeEnumNullish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionTypeEnumNullish
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifier")]
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_view")]
        CustomView,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="facet")]
        Facet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parameters")]
        Parameters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preprocessor")]
        Preprocessor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sandbox")]
        Sandbox,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scorer")]
        Scorer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task")]
        Task,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
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