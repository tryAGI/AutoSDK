//HintName: G.JsonConverters.OrganizationProgrammaticAccessGrantRepositorySelection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrganizationProgrammaticAccessGrantRepositorySelectionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.OrganizationProgrammaticAccessGrantRepositorySelection>
    {
        /// <inheritdoc />
        public override global::G.OrganizationProgrammaticAccessGrantRepositorySelection ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.OrganizationProgrammaticAccessGrantRepositorySelection existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.OrganizationProgrammaticAccessGrantRepositorySelectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.OrganizationProgrammaticAccessGrantRepositorySelection)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.OrganizationProgrammaticAccessGrantRepositorySelection);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.OrganizationProgrammaticAccessGrantRepositorySelection value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.OrganizationProgrammaticAccessGrantRepositorySelectionExtensions.ToValueString(value));
        }
    }
}
