//HintName: G.Models.AddLocalesToDubbingProjectRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the dubbed video.<br/>
    /// Default Value: private<br/>
    /// Example: private
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddLocalesToDubbingProjectRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddLocalesToDubbingProjectRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddLocalesToDubbingProjectRequestVisibility value)
        {
            return value switch
            {
                AddLocalesToDubbingProjectRequestVisibility.Private => "private",
                AddLocalesToDubbingProjectRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddLocalesToDubbingProjectRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => AddLocalesToDubbingProjectRequestVisibility.Private,
                "public" => AddLocalesToDubbingProjectRequestVisibility.Public,
                _ => null,
            };
        }
    }
}