//HintName: G.Models.CreateVirtualTryOnRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model to use for virtual try-on.<br/>
    /// Default Value: kolors-virtual-try-on-v1-5
    /// </summary>
    public enum CreateVirtualTryOnRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        KolorsVirtualTryOnV1,
        /// <summary>
        /// 
        /// </summary>
        KolorsVirtualTryOnV15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVirtualTryOnRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVirtualTryOnRequestModelName value)
        {
            return value switch
            {
                CreateVirtualTryOnRequestModelName.KolorsVirtualTryOnV1 => "kolors-virtual-try-on-v1",
                CreateVirtualTryOnRequestModelName.KolorsVirtualTryOnV15 => "kolors-virtual-try-on-v1-5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVirtualTryOnRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "kolors-virtual-try-on-v1" => CreateVirtualTryOnRequestModelName.KolorsVirtualTryOnV1,
                "kolors-virtual-try-on-v1-5" => CreateVirtualTryOnRequestModelName.KolorsVirtualTryOnV15,
                _ => null,
            };
        }
    }
}