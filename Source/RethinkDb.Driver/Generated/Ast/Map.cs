












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

    public class Map : ReqlExpr {

    
    
    
/// <summary>
/// <para>Transform each element of one or more sequences by applying a mapping function to them. If <code>map</code> is run with two or more sequences, it will iterate for as many items as there are in the shortest sequence.</para>
/// </summary>
/// <example><para>Example: Return the first five squares.</para>
/// <code>r.expr([1, 2, 3, 4, 5]).map(function (val) {
///     return val.mul(val);
/// }).run(conn, callback);
/// // Result passed to callback
/// [1, 4, 9, 16, 25]
/// </code></example>
        public Map (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Transform each element of one or more sequences by applying a mapping function to them. If <code>map</code> is run with two or more sequences, it will iterate for as many items as there are in the shortest sequence.</para>
/// </summary>
/// <example><para>Example: Return the first five squares.</para>
/// <code>r.expr([1, 2, 3, 4, 5]).map(function (val) {
///     return val.mul(val);
/// }).run(conn, callback);
/// // Result passed to callback
/// [1, 4, 9, 16, 25]
/// </code></example>
        public Map (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Transform each element of one or more sequences by applying a mapping function to them. If <code>map</code> is run with two or more sequences, it will iterate for as many items as there are in the shortest sequence.</para>
/// </summary>
/// <example><para>Example: Return the first five squares.</para>
/// <code>r.expr([1, 2, 3, 4, 5]).map(function (val) {
///     return val.mul(val);
/// }).run(conn, callback);
/// // Result passed to callback
/// [1, 4, 9, 16, 25]
/// </code></example>
        public Map (Arguments args, object optargs)
             : this(TermType.MAP, args, optargs) {
        }

    protected Map (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
