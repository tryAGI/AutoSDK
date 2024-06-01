//HintName: JsonConverters.PackagesGetAllPackageVersionsForPackageOwnedByOrgState.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class PackagesGetAllPackageVersionsForPackageOwnedByOrgStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState>
    {
        /// <inheritdoc />
        public override global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgStateExtensions.ToValueString(value));
        }
    }
}
