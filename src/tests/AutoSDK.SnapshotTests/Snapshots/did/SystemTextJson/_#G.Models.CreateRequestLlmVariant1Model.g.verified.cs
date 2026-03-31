//HintName: G.Models.CreateRequestLlmVariant1Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum CreateRequestLlmVariant1Model
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestLlmVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant1Model value)
        {
            return value switch
            {
                CreateRequestLlmVariant1Model.Gpt41 => "gpt-4.1",
                CreateRequestLlmVariant1Model.Gpt41Mini => "gpt-4.1-mini",
                CreateRequestLlmVariant1Model.Gpt41Nano => "gpt-4.1-nano",
                CreateRequestLlmVariant1Model.Gpt4oGlobal => "gpt-4o-global",
                CreateRequestLlmVariant1Model.Gpt4oMini => "gpt-4o-mini",
                CreateRequestLlmVariant1Model.Gpt5Mini => "gpt-5-mini",
                CreateRequestLlmVariant1Model.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => CreateRequestLlmVariant1Model.Gpt41,
                "gpt-4.1-mini" => CreateRequestLlmVariant1Model.Gpt41Mini,
                "gpt-4.1-nano" => CreateRequestLlmVariant1Model.Gpt41Nano,
                "gpt-4o-global" => CreateRequestLlmVariant1Model.Gpt4oGlobal,
                "gpt-4o-mini" => CreateRequestLlmVariant1Model.Gpt4oMini,
                "gpt-5-mini" => CreateRequestLlmVariant1Model.Gpt5Mini,
                "gpt-5-nano" => CreateRequestLlmVariant1Model.Gpt5Nano,
                _ => null,
            };
        }
    }
}