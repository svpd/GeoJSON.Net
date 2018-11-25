// Copyright © Matt Hunt 2017

namespace GeoJSON.Net.CoordinateReferenceSystem
{
    /// <summary>
    /// The default CRS is a geographic coordinate reference system,
    /// using the WGS84 datum, and with longitude and latitude units of decimal degrees.
    /// see https://tools.ietf.org/html/rfc7946#section-4
    /// </summary>
    /// <remarks>
    /// Defines the GeoJSON Coordinate Reference System Objects (CRS) types originally defined in the geojson.org v1.0 spec
    /// see http://geojson.org/geojson-spec.html#coordinate-reference-system-objects.
    /// The current RFC removes the CRS type, but allows to be left in for backwards compatibility. See https://tools.ietf.org/html/rfc7946#section-4
    /// </remarks>
    public class Wgs84CRS : NamedCRS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wgs84CRS" /> class.
        /// </summary>
        private Wgs84CRS()
            : base("urn:ogc:def:crs:OGC::CRS84")
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Wgs84CRS Instance { get; } = new Wgs84CRS();
    }
}