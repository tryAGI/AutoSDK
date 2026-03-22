//HintName: G.Models.BatchObjectsCreateRequestField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: ALL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchObjectsCreateRequestField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="class")]
        Class,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creationTimeUnix")]
        CreationTimeUnix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="schema")]
        Schema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectsCreateRequestFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectsCreateRequestField value)
        {
            return value switch
            {
                BatchObjectsCreateRequestField.All => "ALL",
                BatchObjectsCreateRequestField.Class => "class",
                BatchObjectsCreateRequestField.CreationTimeUnix => "creationTimeUnix",
                BatchObjectsCreateRequestField.Id => "id",
                BatchObjectsCreateRequestField.Schema => "schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectsCreateRequestField? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => BatchObjectsCreateRequestField.All,
                "class" => BatchObjectsCreateRequestField.Class,
                "creationTimeUnix" => BatchObjectsCreateRequestField.CreationTimeUnix,
                "id" => BatchObjectsCreateRequestField.Id,
                "schema" => BatchObjectsCreateRequestField.Schema,
                _ => null,
            };
        }
    }
}