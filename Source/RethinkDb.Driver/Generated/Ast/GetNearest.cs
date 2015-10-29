












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class GetNearest : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get all documents where the specified geospatial index is within a certain distance of the specified point (default 100 kilometers).</para>
/// </summary>
/// <example><para>Example: Return a list of enemy hideouts within 5000 meters of the secret base.</para>
/// <code>var secretBase = r.point(-122.422876,37.777128);
/// r.table('hideouts').getNearest(secretBase,
///     {index: 'location', maxDist: 5000}
/// ).run(conn, callback)
/// </code></example>
        public GetNearest (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get all documents where the specified geospatial index is within a certain distance of the specified point (default 100 kilometers).</para>
/// </summary>
/// <example><para>Example: Return a list of enemy hideouts within 5000 meters of the secret base.</para>
/// <code>var secretBase = r.point(-122.422876,37.777128);
/// r.table('hideouts').getNearest(secretBase,
///     {index: 'location', maxDist: 5000}
/// ).run(conn, callback)
/// </code></example>
        public GetNearest (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get all documents where the specified geospatial index is within a certain distance of the specified point (default 100 kilometers).</para>
/// </summary>
/// <example><para>Example: Return a list of enemy hideouts within 5000 meters of the secret base.</para>
/// <code>var secretBase = r.point(-122.422876,37.777128);
/// r.table('hideouts').getNearest(secretBase,
///     {index: 'location', maxDist: 5000}
/// ).run(conn, callback)
/// </code></example>
        public GetNearest (Arguments args, object optargs)
             : this(TermType.GET_NEAREST, args, optargs) {
        }

    protected GetNearest (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "index": "T_STR",
///  "max_results": "T_NUM",
///  "unit": "E_UNIT",
///  "max_dist": "T_NUM",
///  "geo_system": "E_GEO_SYSTEM"
///</summary>
        public GetNearest this[object optArgs] {
            get
            {
                if(this.OptArgs is Hashtable)
                    throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
                return new GetNearest (this.Args, optArgs);
            }
        }
        
///<summary>
/// "index": "T_STR",
///  "max_results": "T_NUM",
///  "unit": "E_UNIT",
///  "max_dist": "T_NUM",
///  "geo_system": "E_GEO_SYSTEM"
///</summary>
        public GetNearest optArg(string key, object val){
            if (this.OptArgs != null && !(this.OptArgs is Hashtable))
                throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
            var optArgs = this.OptArgs as Hashtable ?? new Hashtable();
            optArgs[key] = val;
        
            return new GetNearest (this.Args, optArgs);
        }


    

    


    
    }
}
