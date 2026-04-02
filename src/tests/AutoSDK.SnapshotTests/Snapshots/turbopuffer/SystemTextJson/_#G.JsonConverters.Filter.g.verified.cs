//HintName: G.JsonConverters.Filter.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Filter>
    {
        /// <inheritdoc />
        public override global::G.Filter Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __score7 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __score8 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
                    }
                }
            }
            var __score9 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score9++;
                    }
                }
            }
            var __score10 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score10++;
                    }
                }
            }
            var __score11 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score11++;
                    }
                }
            }
            var __score12 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score12++;
                    }
                }
            }
            var __score13 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score13++;
                    }
                }
            }
            var __score14 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score14++;
                    }
                }
            }
            var __score15 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score15++;
                    }
                }
            }
            var __score16 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score16++;
                    }
                }
            }
            var __score17 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score17++;
                    }
                }
            }
            var __score18 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score18++;
                    }
                }
            }
            var __score19 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score19++;
                    }
                }
            }
            var __score20 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score20++;
                    }
                }
            }
            var __score21 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score21++;
                    }
                }
            }
            var __score22 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score22++;
                    }
                }
            }
            var __score23 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score23++;
                    }
                }
            }
            var __score24 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score24++;
                    }
                }
            }
            var __score25 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score25++;
                    }
                }
            }
            var __score26 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score26++;
                    }
                }
            }
            var __score27 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score27++;
                    }
                }
            }
            var __score28 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score28++;
                    }
                }
            }
            var __score29 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score29++;
                    }
                }
            }
            var __score30 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score30++;
                    }
                }
            }
            var __score31 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score31++;
                    }
                }
            }
            var __score32 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score32++;
                    }
                }
            }
            var __score33 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(byte[]), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score33++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }
            if (__score32 > __bestScore) { __bestScore = __score32; __bestIndex = 32; }
            if (__score33 > __bestScore) { __bestScore = __score33; __bestIndex = 33; }

            byte[]? filterVariant1 = default;
            byte[]? filterVariant2 = default;
            byte[]? filterVariant3 = default;
            byte[]? filterVariant4 = default;
            byte[]? filterVariant5 = default;
            byte[]? filterVariant6 = default;
            byte[]? filterVariant7 = default;
            byte[]? filterVariant8 = default;
            byte[]? filterVariant9 = default;
            byte[]? filterVariant10 = default;
            byte[]? filterVariant11 = default;
            byte[]? filterVariant12 = default;
            byte[]? filterVariant13 = default;
            byte[]? filterVariant14 = default;
            byte[]? filterVariant15 = default;
            byte[]? filterVariant16 = default;
            byte[]? filterVariant17 = default;
            byte[]? filterVariant18 = default;
            byte[]? filterVariant19 = default;
            byte[]? filterVariant20 = default;
            byte[]? filterVariant21 = default;
            byte[]? filterVariant22 = default;
            byte[]? filterVariant23 = default;
            byte[]? filterVariant24 = default;
            byte[]? filterVariant25 = default;
            byte[]? filterVariant26 = default;
            byte[]? filterVariant27 = default;
            byte[]? filterVariant28 = default;
            byte[]? filterVariant29 = default;
            byte[]? filterVariant30 = default;
            byte[]? filterVariant31 = default;
            byte[]? filterVariant32 = default;
            byte[]? filterVariant33 = default;
            byte[]? filterVariant34 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 9)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 10)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 11)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 12)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 13)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 14)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 15)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 16)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 17)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 18)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 19)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 20)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 21)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 22)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 23)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 24)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 25)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant26 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 26)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant27 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 27)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant28 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 28)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant29 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 29)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant30 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 30)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 31)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant32 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 32)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant33 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 33)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        filterVariant34 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (filterVariant1 == null && filterVariant2 == null && filterVariant3 == null && filterVariant4 == null && filterVariant5 == null && filterVariant6 == null && filterVariant7 == null && filterVariant8 == null && filterVariant9 == null && filterVariant10 == null && filterVariant11 == null && filterVariant12 == null && filterVariant13 == null && filterVariant14 == null && filterVariant15 == null && filterVariant16 == null && filterVariant17 == null && filterVariant18 == null && filterVariant19 == null && filterVariant20 == null && filterVariant21 == null && filterVariant22 == null && filterVariant23 == null && filterVariant24 == null && filterVariant25 == null && filterVariant26 == null && filterVariant27 == null && filterVariant28 == null && filterVariant29 == null && filterVariant30 == null && filterVariant31 == null && filterVariant32 == null && filterVariant33 == null && filterVariant34 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant26 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant27 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant28 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant29 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant30 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant32 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant33 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    filterVariant34 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Filter(
                filterVariant1,

                filterVariant2,

                filterVariant3,

                filterVariant4,

                filterVariant5,

                filterVariant6,

                filterVariant7,

                filterVariant8,

                filterVariant9,

                filterVariant10,

                filterVariant11,

                filterVariant12,

                filterVariant13,

                filterVariant14,

                filterVariant15,

                filterVariant16,

                filterVariant17,

                filterVariant18,

                filterVariant19,

                filterVariant20,

                filterVariant21,

                filterVariant22,

                filterVariant23,

                filterVariant24,

                filterVariant25,

                filterVariant26,

                filterVariant27,

                filterVariant28,

                filterVariant29,

                filterVariant30,

                filterVariant31,

                filterVariant32,

                filterVariant33,

                filterVariant34
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Filter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFilterVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant1!, typeInfo);
            }
            else if (value.IsFilterVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant2!, typeInfo);
            }
            else if (value.IsFilterVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant3!, typeInfo);
            }
            else if (value.IsFilterVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant4!, typeInfo);
            }
            else if (value.IsFilterVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant5!, typeInfo);
            }
            else if (value.IsFilterVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant6!, typeInfo);
            }
            else if (value.IsFilterVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant7!, typeInfo);
            }
            else if (value.IsFilterVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant8!, typeInfo);
            }
            else if (value.IsFilterVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant9!, typeInfo);
            }
            else if (value.IsFilterVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant10!, typeInfo);
            }
            else if (value.IsFilterVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant11!, typeInfo);
            }
            else if (value.IsFilterVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant12!, typeInfo);
            }
            else if (value.IsFilterVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant13!, typeInfo);
            }
            else if (value.IsFilterVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant14!, typeInfo);
            }
            else if (value.IsFilterVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant15!, typeInfo);
            }
            else if (value.IsFilterVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant16!, typeInfo);
            }
            else if (value.IsFilterVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant17!, typeInfo);
            }
            else if (value.IsFilterVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant18!, typeInfo);
            }
            else if (value.IsFilterVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant19!, typeInfo);
            }
            else if (value.IsFilterVariant20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant20!, typeInfo);
            }
            else if (value.IsFilterVariant21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant21!, typeInfo);
            }
            else if (value.IsFilterVariant22)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant22!, typeInfo);
            }
            else if (value.IsFilterVariant23)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant23!, typeInfo);
            }
            else if (value.IsFilterVariant24)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant24!, typeInfo);
            }
            else if (value.IsFilterVariant25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant25!, typeInfo);
            }
            else if (value.IsFilterVariant26)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant26!, typeInfo);
            }
            else if (value.IsFilterVariant27)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant27!, typeInfo);
            }
            else if (value.IsFilterVariant28)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant28!, typeInfo);
            }
            else if (value.IsFilterVariant29)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant29!, typeInfo);
            }
            else if (value.IsFilterVariant30)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant30!, typeInfo);
            }
            else if (value.IsFilterVariant31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant31!, typeInfo);
            }
            else if (value.IsFilterVariant32)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant32!, typeInfo);
            }
            else if (value.IsFilterVariant33)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant33!, typeInfo);
            }
            else if (value.IsFilterVariant34)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilterVariant34!, typeInfo);
            }
        }
    }
}