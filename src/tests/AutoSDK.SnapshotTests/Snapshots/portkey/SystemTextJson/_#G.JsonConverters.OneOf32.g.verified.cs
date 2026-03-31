//HintName: G.JsonConverters.OneOf32.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OneOfJsonConverter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> : global::System.Text.Json.Serialization.JsonConverter<global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>>
    {
        /// <inheritdoc />
        public override global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T15), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T16), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T17), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T18), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T19), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T20), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T21), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T22), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T23), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T24), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T25), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T26), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T27), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T28), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T29), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T30), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T31), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(T32), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score31++;
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

            T1? value1 = default;
            T2? value2 = default;
            T3? value3 = default;
            T4? value4 = default;
            T5? value5 = default;
            T6? value6 = default;
            T7? value7 = default;
            T8? value8 = default;
            T9? value9 = default;
            T10? value10 = default;
            T11? value11 = default;
            T12? value12 = default;
            T13? value13 = default;
            T14? value14 = default;
            T15? value15 = default;
            T16? value16 = default;
            T17? value17 = default;
            T18? value18 = default;
            T19? value19 = default;
            T20? value20 = default;
            T21? value21 = default;
            T22? value22 = default;
            T23? value23 = default;
            T24? value24 = default;
            T25? value25 = default;
            T26? value26 = default;
            T27? value27 = default;
            T28? value28 = default;
            T29? value29 = default;
            T30? value30 = default;
            T31? value31 = default;
            T32? value32 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                        value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                        value6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                        value7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                        value8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                        value9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                        value10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                        value11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                        value12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                        value13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T14).Name}");
                        value14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T15).Name}");
                        value15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T16).Name}");
                        value16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T17).Name}");
                        value17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T18).Name}");
                        value18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T19).Name}");
                        value19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T20> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T20).Name}");
                        value20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T21> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T21).Name}");
                        value21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T22> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T22).Name}");
                        value22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T23> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T23).Name}");
                        value23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T24> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T24).Name}");
                        value24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T25> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T25).Name}");
                        value25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T26), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T26> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T26).Name}");
                        value26 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T27), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T27> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T27).Name}");
                        value27 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T28), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T28> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T28).Name}");
                        value28 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T29), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T29> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T29).Name}");
                        value29 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T30), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T30> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T30).Name}");
                        value30 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T31> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T31).Name}");
                        value31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T32), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T32> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T32).Name}");
                        value32 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null && value5 == null && value6 == null && value7 == null && value8 == null && value9 == null && value10 == null && value11 == null && value12 == null && value13 == null && value14 == null && value15 == null && value16 == null && value17 == null && value18 == null && value19 == null && value20 == null && value21 == null && value22 == null && value23 == null && value24 == null && value25 == null && value26 == null && value27 == null && value28 == null && value29 == null && value30 == null && value31 == null && value32 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                    value5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                    value6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                    value7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                    value8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                    value9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                    value10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                    value11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                    value12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                    value13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T14).Name}");
                    value14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T15).Name}");
                    value15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T16).Name}");
                    value16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T17).Name}");
                    value17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T18).Name}");
                    value18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T19).Name}");
                    value19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T20> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T20).Name}");
                    value20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T21> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T21).Name}");
                    value21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T22> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T22).Name}");
                    value22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T23> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T23).Name}");
                    value23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T24> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T24).Name}");
                    value24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T25> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T25).Name}");
                    value25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T26), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T26> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T26).Name}");
                    value26 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T27), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T27> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T27).Name}");
                    value27 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T28), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T28> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T28).Name}");
                    value28 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T29), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T29> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T29).Name}");
                    value29 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T30), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T30> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T30).Name}");
                    value30 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T31> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T31).Name}");
                    value31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T32), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T32> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T32).Name}");
                    value32 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(
                value1,

                value2,

                value3,

                value4,

                value5,

                value6,

                value7,

                value8,

                value9,

                value10,

                value11,

                value12,

                value13,

                value14,

                value15,

                value16,

                value17,

                value18,

                value19,

                value20,

                value21,

                value22,

                value23,

                value24,

                value25,

                value26,

                value27,

                value28,

                value29,

                value30,

                value31,

                value32
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5!, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6!, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7!, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8!, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9!, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10!, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11!, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12!, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13!, typeInfo);
            }
            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14!, typeInfo);
            }
            else if (value.IsValue15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15!, typeInfo);
            }
            else if (value.IsValue16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16!, typeInfo);
            }
            else if (value.IsValue17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17!, typeInfo);
            }
            else if (value.IsValue18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18!, typeInfo);
            }
            else if (value.IsValue19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19!, typeInfo);
            }
            else if (value.IsValue20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20!, typeInfo);
            }
            else if (value.IsValue21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value21!, typeInfo);
            }
            else if (value.IsValue22)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T22?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value22!, typeInfo);
            }
            else if (value.IsValue23)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T23?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value23!, typeInfo);
            }
            else if (value.IsValue24)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T24?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value24!, typeInfo);
            }
            else if (value.IsValue25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value25!, typeInfo);
            }
            else if (value.IsValue26)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T26), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T26?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T26).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value26!, typeInfo);
            }
            else if (value.IsValue27)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T27), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T27?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T27).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value27!, typeInfo);
            }
            else if (value.IsValue28)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T28), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T28?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T28).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value28!, typeInfo);
            }
            else if (value.IsValue29)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T29), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T29?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T29).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value29!, typeInfo);
            }
            else if (value.IsValue30)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T30), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T30?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T30).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value30!, typeInfo);
            }
            else if (value.IsValue31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value31!, typeInfo);
            }
            else if (value.IsValue32)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T32), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T32?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T32).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value32!, typeInfo);
            }
        }
    }
}