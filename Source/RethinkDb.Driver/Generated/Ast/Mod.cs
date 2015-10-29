












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

    public class Mod : ReqlExpr {

    
    
    
/// <summary>
/// <para>Find the remainder when dividing two numbers.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 % 2 = 0.</para>
/// <code>r.expr(2).mod(2).run(conn, callback)
/// </code></example>
        public Mod (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Find the remainder when dividing two numbers.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 % 2 = 0.</para>
/// <code>r.expr(2).mod(2).run(conn, callback)
/// </code></example>
        public Mod (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Find the remainder when dividing two numbers.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 % 2 = 0.</para>
/// <code>r.expr(2).mod(2).run(conn, callback)
/// </code></example>
        public Mod (Arguments args, object optargs)
             : this(TermType.MOD, args, optargs) {
        }

    protected Mod (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
