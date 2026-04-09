//HintName: G.JsonConverters.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SecurityAdvisoriesListOrgRepositoryAdvisoriesSortJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort>
    {
        /// <inheritdoc />
        public override global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort existingValue,
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
                        return global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSortExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSortExtensions.ToValueString(value));
        }
    }
}
