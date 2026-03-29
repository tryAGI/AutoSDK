//HintName: G.Models.CreateModelRequestVisibility2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
    /// Default Value: public
    /// </summary>
    public enum CreateModelRequestVisibility2
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelRequestVisibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestVisibility2 value)
        {
            return value switch
            {
                CreateModelRequestVisibility2.Private => "private",
                CreateModelRequestVisibility2.Public => "public",
                CreateModelRequestVisibility2.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestVisibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateModelRequestVisibility2.Private,
                "public" => CreateModelRequestVisibility2.Public,
                "unlist" => CreateModelRequestVisibility2.Unlist,
                _ => null,
            };
        }
    }
}