//HintName: G.Models.TransformersModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransformersModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automodel")]
        Automodel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automodel-causallm")]
        AutomodelCausallm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automodel-imagetexttotext")]
        AutomodelImagetexttotext,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automodel-vision2seq")]
        AutomodelVision2seq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransformersModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransformersModelType value)
        {
            return value switch
            {
                TransformersModelType.Automodel => "automodel",
                TransformersModelType.AutomodelCausallm => "automodel-causallm",
                TransformersModelType.AutomodelImagetexttotext => "automodel-imagetexttotext",
                TransformersModelType.AutomodelVision2seq => "automodel-vision2seq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransformersModelType? ToEnum(string value)
        {
            return value switch
            {
                "automodel" => TransformersModelType.Automodel,
                "automodel-causallm" => TransformersModelType.AutomodelCausallm,
                "automodel-imagetexttotext" => TransformersModelType.AutomodelImagetexttotext,
                "automodel-vision2seq" => TransformersModelType.AutomodelVision2seq,
                _ => null,
            };
        }
    }
}