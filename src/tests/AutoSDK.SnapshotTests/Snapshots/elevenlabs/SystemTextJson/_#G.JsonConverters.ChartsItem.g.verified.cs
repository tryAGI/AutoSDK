//HintName: G.JsonConverters.ChartsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChartsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChartsItem>
    {
        /// <inheritdoc />
        public override global::G.ChartsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetConvAIDashboardSettingsResponseModelChartDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetConvAIDashboardSettingsResponseModelChartDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetConvAIDashboardSettingsResponseModelChartDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DashboardCallSuccessChartModel? callSuccess = default;
            if (discriminator?.Type == global::G.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.CallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DashboardCallSuccessChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DashboardCallSuccessChartModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DashboardCallSuccessChartModel)}");
                callSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DashboardCriteriaChartModel? criteria = default;
            if (discriminator?.Type == global::G.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.Criteria)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DashboardCriteriaChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DashboardCriteriaChartModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DashboardCriteriaChartModel)}");
                criteria = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DashboardDataCollectionChartModel? dataCollection = default;
            if (discriminator?.Type == global::G.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.DataCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DashboardDataCollectionChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DashboardDataCollectionChartModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DashboardDataCollectionChartModel)}");
                dataCollection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ChartsItem(
                discriminator?.Type,
                callSuccess,
                criteria,
                dataCollection
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChartsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DashboardCallSuccessChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DashboardCallSuccessChartModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DashboardCallSuccessChartModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallSuccess, typeInfo);
            }
            else if (value.IsCriteria)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DashboardCriteriaChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DashboardCriteriaChartModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DashboardCriteriaChartModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Criteria, typeInfo);
            }
            else if (value.IsDataCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DashboardDataCollectionChartModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DashboardDataCollectionChartModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DashboardDataCollectionChartModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataCollection, typeInfo);
            }
        }
    }
}