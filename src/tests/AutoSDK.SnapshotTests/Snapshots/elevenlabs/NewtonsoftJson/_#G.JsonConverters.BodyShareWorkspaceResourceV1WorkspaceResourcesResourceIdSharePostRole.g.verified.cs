//HintName: G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole>
    {
        /// <inheritdoc />
        public override global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole existingValue,
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
                        return global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleExtensions.ToValueString(value));
        }
    }
}
