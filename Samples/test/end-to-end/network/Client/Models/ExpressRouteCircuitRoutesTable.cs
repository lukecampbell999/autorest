// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        /// <param name="networkProperty">network</param>
        /// <param name="nextHop">nextHop</param>
        /// <param name="locPrf">locPrf</param>
        /// <param name="weight">weight.</param>
        /// <param name="path">path</param>
        public ExpressRouteCircuitRoutesTable(string networkProperty = default(string), string nextHop = default(string), string locPrf = default(string), int? weight = default(int?), string path = default(string))
        {
            NetworkProperty = networkProperty;
            NextHop = nextHop;
            LocPrf = locPrf;
            Weight = weight;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets network
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string NetworkProperty { get; set; }

        /// <summary>
        /// Gets or sets nextHop
        /// </summary>
        [JsonProperty(PropertyName = "nextHop")]
        public string NextHop { get; set; }

        /// <summary>
        /// Gets or sets locPrf
        /// </summary>
        [JsonProperty(PropertyName = "locPrf")]
        public string LocPrf { get; set; }

        /// <summary>
        /// Gets or sets weight.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets path
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}
