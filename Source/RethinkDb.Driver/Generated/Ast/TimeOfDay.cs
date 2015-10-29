












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

    public class TimeOfDay : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the number of seconds elapsed since the beginning of the day stored in the time object.</para>
/// </summary>
/// <example><para>Example: Retrieve posts that were submitted before noon.</para>
/// <code>r.table("posts").filter(
///     r.row("date").timeOfDay().le(12*60*60)
/// ).run(conn, callback)
/// </code></example>
        public TimeOfDay (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the number of seconds elapsed since the beginning of the day stored in the time object.</para>
/// </summary>
/// <example><para>Example: Retrieve posts that were submitted before noon.</para>
/// <code>r.table("posts").filter(
///     r.row("date").timeOfDay().le(12*60*60)
/// ).run(conn, callback)
/// </code></example>
        public TimeOfDay (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the number of seconds elapsed since the beginning of the day stored in the time object.</para>
/// </summary>
/// <example><para>Example: Retrieve posts that were submitted before noon.</para>
/// <code>r.table("posts").filter(
///     r.row("date").timeOfDay().le(12*60*60)
/// ).run(conn, callback)
/// </code></example>
        public TimeOfDay (Arguments args, object optargs)
             : this(TermType.TIME_OF_DAY, args, optargs) {
        }

    protected TimeOfDay (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
