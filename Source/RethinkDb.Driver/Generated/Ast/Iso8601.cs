












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

    public class Iso8601 : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a time object based on an ISO 8601 date-time string (e.g. '2013-01-01T01:01:01+00:00'). We support all valid ISO 8601 formats except for week dates. If you pass an ISO 8601 date-time without a time zone, you must specify the time zone with the <code>defaultTimezone</code> argument. Read more about the ISO 8601 format at <a href="http://en.wikipedia.org/wiki/ISO_8601">Wikipedia</a>.</para>
/// </summary>
/// <example><para>Example: Update the time of John's birth.</para>
/// <code>r.table("user").get("John").update({birth: r.ISO8601('1986-11-03T08:30:00-07:00')}).run(conn, callback)
/// </code></example>
        public Iso8601 (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a time object based on an ISO 8601 date-time string (e.g. '2013-01-01T01:01:01+00:00'). We support all valid ISO 8601 formats except for week dates. If you pass an ISO 8601 date-time without a time zone, you must specify the time zone with the <code>defaultTimezone</code> argument. Read more about the ISO 8601 format at <a href="http://en.wikipedia.org/wiki/ISO_8601">Wikipedia</a>.</para>
/// </summary>
/// <example><para>Example: Update the time of John's birth.</para>
/// <code>r.table("user").get("John").update({birth: r.ISO8601('1986-11-03T08:30:00-07:00')}).run(conn, callback)
/// </code></example>
        public Iso8601 (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a time object based on an ISO 8601 date-time string (e.g. '2013-01-01T01:01:01+00:00'). We support all valid ISO 8601 formats except for week dates. If you pass an ISO 8601 date-time without a time zone, you must specify the time zone with the <code>defaultTimezone</code> argument. Read more about the ISO 8601 format at <a href="http://en.wikipedia.org/wiki/ISO_8601">Wikipedia</a>.</para>
/// </summary>
/// <example><para>Example: Update the time of John's birth.</para>
/// <code>r.table("user").get("John").update({birth: r.ISO8601('1986-11-03T08:30:00-07:00')}).run(conn, callback)
/// </code></example>
        public Iso8601 (Arguments args, object optargs)
             : this(TermType.ISO8601, args, optargs) {
        }

    protected Iso8601 (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "default_timezone": "T_STR"
///</summary>
        public Iso8601 this[object optArgs] {
            get
            {
                if(this.OptArgs is Hashtable)
                    throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
                return new Iso8601 (this.Args, optArgs);
            }
        }
        
///<summary>
/// "default_timezone": "T_STR"
///</summary>
        public Iso8601 optArg(string key, object val){
            if (this.OptArgs != null && !(this.OptArgs is Hashtable))
                throw new ReqlError("Either use .optArg() methods or anonymous optArgs types but not both.");
        
            var optArgs = this.OptArgs as Hashtable ?? new Hashtable();
            optArgs[key] = val;
        
            return new Iso8601 (this.Args, optArgs);
        }


    







       
      

    
        
    public static Iso8601 FromString(string iso) {
       return new Iso8601 (new Arguments(iso), null);
    }



    
    }
}
