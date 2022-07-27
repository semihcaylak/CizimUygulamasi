using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Painter.Interfaces;

namespace Painter.Helpers
{
    public  class IShapeTypeMapper<TImplementation> :JsonConverter<IShape>
        where TImplementation : IShape
    {
        public override IShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => JsonSerializer.Deserialize<TImplementation>(ref reader, options);

        public override void Write(Utf8JsonWriter writer, IShape value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, (TImplementation)value!, options);
    }
}
