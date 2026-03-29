//HintName: G.Models.CreateSupabaseCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is for supabase storage.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSupabaseCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supabase")]
        Supabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSupabaseCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSupabaseCredentialDTOProvider value)
        {
            return value switch
            {
                CreateSupabaseCredentialDTOProvider.Supabase => "supabase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSupabaseCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "supabase" => CreateSupabaseCredentialDTOProvider.Supabase,
                _ => null,
            };
        }
    }
}