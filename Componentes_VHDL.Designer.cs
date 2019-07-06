﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uPD {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Componentes_VHDL {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Componentes_VHDL() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("uPD.Componentes_VHDL", typeof(Componentes_VHDL).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity BANCO_REGISTRADOR is
        ///    Generic (
        ///					p_DATA_WIDTH		: INTEGER := 16
        ///	 );
        ///    Port ( 
        ///				i_CLK   		: in  STD_LOGIC;
        ///				i_RST   		: in  STD_LOGIC;
        ///				
        ///				i_ADD_S1		: in  STD_LOGIC_VECTOR(1 DOWNTO 0);	  
        ///				i_ADD_S2		: in  STD_LOGIC_VECTOR(1 DOWNTO 0);	
        ///
        ///				i_RET			: in  STD_LOGIC;
        ///				i_DOUT_LIFO 	: in  STD_LOGIC_VECTOR(63 DOWNTO 0);
        ///				o_DIN_LIFO  	: out STD_LOGIC_VEC [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string banco_registradores {
            get {
                return ResourceManager.GetString("banco_registradores", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity CAMINHO_CONTROLE is
        ///	 Generic(
        ///	 		p_DATA_WIDTH   : INTEGER := 16;        -- Número de bits dos dados. 
        ///	 		p_ADD_WIDTH    : INTEGER := 9         -- Número de bits dos endereços. 
        ///	 );
        ///    Port ( 
        ///				i_CLK		: in  STD_LOGIC;
        ///				i_RST		: in  STD_LOGIC;
        ///				
        ///				i_DATA_ROM	: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	  
        ///				i_DATA_ULA	: in  STD_LOGIC;
        ///				o_SEL_ULA	: out S [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string caminho_controle {
            get {
                return ResourceManager.GetString("caminho_controle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity CAMINHO_DADOS is
        ///    Generic (
        ///					p_DATA_WIDTH			: INTEGER := 16
        ///	 );
        ///    Port ( 
        ///				i_CLK			: in  STD_LOGIC;
        ///				i_RST			: in  STD_LOGIC;
        ///				i_DATA			: in  STD_LOGIC_VECTOR(10 DOWNTO 0);	  
        ///				i_SEL_ULA		: in  STD_LOGIC_VECTOR(2 DOWNTO 0);	
        ///				i_SEL_IMED		: in  STD_LOGIC_VECTOR(1 DOWNTO 0);	
        ///			    i_WR_BCO		: in  STD_LOGIC;
        ///				i_WR_RAM    	: in  STD_LOGIC;
        ///				i_WR_IO [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string caminho_dados {
            get {
                return ResourceManager.GetString("caminho_dados", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity CONTROLE is
        ///    Generic (
        ///				p_DATA_WIDTH	: INTEGER := 16
        ///    );	
        ///    Port ( 
        ///				i_CLK			: in  STD_LOGIC;
        ///				i_RST			: in  STD_LOGIC;
        ///				i_DATA   		: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	  
        ///				i_DATA_ULA		: in  STD_LOGIC;
        ///				o_SEL_ULA		: out STD_LOGIC_VECTOR(2 DOWNTO 0);	
        ///				o_SEL_IMED		: out STD_LOGIC_VECTOR(1 DOWNTO 0);	
        ///				o_WR_BCO      	: out STD_LOGIC;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string controle {
            get {
                return ResourceManager.GetString("controle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity CPU is
        ///    Generic (
        ///				p_ADD_WIDTH		: INTEGER := 11;
        ///				p_DATA_WIDTH	: INTEGER := 16
        ///    );
        ///    Port ( 
        ///				i_CLK		: in  STD_LOGIC;
        ///				i_RST		: in  STD_LOGIC;			
        ///
        ///				o_WR_IO    	: out STD_LOGIC;
        ///				o_RD_IO		: out STD_LOGIC;				
        ///				i_DATA_IO	: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);
        ///				o_DATA_IO	: out STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);
        ///				o_ADDR_IO  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CPU {
            get {
                return ResourceManager.GetString("CPU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity INTERRUPCAO is
        ///    Port ( 
        ///			i_CLK   	: in  STD_LOGIC;
        ///			i_RST   	: in  STD_LOGIC;
        ///			i_INT_ADD	: in  STD_LOGIC_VECTOR(1 DOWNTO 0);
        ///			i_INT0		: in  STD_LOGIC;
        ///			i_INT1		: in  STD_LOGIC;
        ///			i_INT2		: in  STD_LOGIC;
        ///			o_BUSY      : out STD_LOGIC;
        ///			o_INT0		: out STD_LOGIC;
        ///			o_INT1		: out STD_LOGIC;
        ///			o_INT2		: out STD_LOGIC			
        ///	 );
        ///end INTERRUPCAO;
        ///
        ///architecture Beha [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Interrupcao {
            get {
                return ResourceManager.GetString("Interrupcao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_arith.ALL;
        ///use IEEE.STD_LOGIC_unsigned.ALL;
        ///
        ///entity LIFO is
        ///	 Generic(
        ///	 		p_DATA_WIDTH   : INTEGER := 16;        -- Número de bits dos dados. 
        ///	 		p_ADD_WIDTH    : INTEGER := 9         -- Número de bits dos endereços. 
        ///	 );
        ///    Port ( 
        ///		  i_CLK 	: in  STD_LOGIC;
        ///		  i_RST   	: in  STD_LOGIC;
        ///		  i_RD 		: in  STD_LOGIC;
        ///		  i_WR 		: in  STD_LOGIC;
        ///		  i_DATA  	: in  STD_LOGIC_VECTOR ((p_DATA_WIDTH-1) downto 0);
        ///		  o_DATA  	: out [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string lifo {
            get {
                return ResourceManager.GetString("lifo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_arith.ALL;
        ///use IEEE.STD_LOGIC_unsigned.ALL;
        ///
        ///entity LIFO is
        ///	 Generic(
        ///	 		p_DATA_WIDTH   : INTEGER := 16;        -- Número de bits dos dados. 
        ///	 		p_ADD_WIDTH    : INTEGER := 9         -- Número de bits dos endereços. 
        ///	 );
        ///    Port ( 
        ///		  i_CLK 	: in  STD_LOGIC;
        ///		  i_RST   	: in  STD_LOGIC;
        ///		  i_RD 		: in  STD_LOGIC;
        ///		  i_WR 		: in  STD_LOGIC;
        ///		  i_DATA  	: in  STD_LOGIC_VECTOR ((p_DATA_WIDTH-1) downto 0);
        ///		  o_DATA  	: out [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string memoria {
            get {
                return ResourceManager.GetString("memoria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LIBRARY ieee;
        ///USE ieee.std_logic_1164.all;
        ///
        ///LIBRARY altera_mf;
        ///USE altera_mf.all;
        ///
        ///ENTITY pll IS
        ///	PORT
        ///	(
        ///		areset		: IN STD_LOGIC  := &apos;0&apos;;
        ///		inclk0		: IN STD_LOGIC  := &apos;0&apos;;
        ///		c0		: OUT STD_LOGIC ;
        ///		locked		: OUT STD_LOGIC 
        ///	);
        ///END pll;
        ///
        ///
        ///ARCHITECTURE SYN OF pll IS
        ///
        ///	SIGNAL sub_wire0	: STD_LOGIC ;
        ///	SIGNAL sub_wire1	: STD_LOGIC_VECTOR (4 DOWNTO 0);
        ///	SIGNAL sub_wire2	: STD_LOGIC ;
        ///	SIGNAL sub_wire3	: STD_LOGIC ;
        ///	SIGNAL sub_wire4	: STD_LOGIC_VECTOR (1 DOWNTO 0);
        ///	SIGNAL sub_wire5_bv	: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string pll {
            get {
                return ResourceManager.GetString("pll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity PROCESSADOR is
        ///	 Generic(
        ///	 		p_DATA_WIDTH   : INTEGER := 16;        -- Número de bits dos dados. 
        ///	 		p_ADD_WIDTH    : INTEGER := 9         -- Número de bits dos endereços. 
        ///	 );
        ///   Port ( 
        ///				i_CLK		: in  STD_LOGIC;
        ///				i_RST		: in  STD_LOGIC;
        ///				
        ///				o_EN_CLK	: out STD_LOGIC;
        ///				o_EN_ROM	: out STD_LOGIC;
        ///				i_DATA_ROM	: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string processador {
            get {
                return ResourceManager.GetString("processador", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LIBRARY ieee;
        ///USE ieee.std_logic_1164.all;
        ///
        ///LIBRARY altera_mf;
        ///USE altera_mf.all;
        ///
        ///ENTITY prom IS
        ///	PORT
        ///	(
        ///		aclr		: IN STD_LOGIC  := &apos;0&apos;;
        ///		address		: IN STD_LOGIC_VECTOR (8 DOWNTO 0);
        ///		clken		: IN STD_LOGIC  := &apos;1&apos;;
        ///		clock		: IN STD_LOGIC  := &apos;1&apos;;
        ///		rden		: IN STD_LOGIC  := &apos;1&apos;;
        ///		q		: OUT STD_LOGIC_VECTOR (15 DOWNTO 0)
        ///	);
        ///END prom;
        ///
        ///
        ///ARCHITECTURE SYN OF prom IS
        ///
        ///	SIGNAL sub_wire0	: STD_LOGIC_VECTOR (15 DOWNTO 0);
        ///
        ///
        ///
        ///	COMPONENT altsyncram
        ///	GENERIC (
        ///		address_aclr_a		: STRING [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string prom {
            get {
                return ResourceManager.GetString("prom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity REGISTRADOR is
        ///	 Generic (
        ///				p_DATA_WIDTH		: INTEGER := 12
        ///	 );
        ///    Port ( 
        ///				i_CLK   	: in  STD_LOGIC;
        ///				i_RST   	: in  STD_LOGIC;
        ///				i_DATA	: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	  
        ///				o_DATA	: out STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	
        ///			     i_WR   	: in  STD_LOGIC	
        ///	 );
        ///end REGISTRADOR;
        ///
        ///architecture Behavioral of REGISTRADOR is
        ///
        ///	
        ///begin
        ///
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string registrador {
            get {
                return ResourceManager.GetString("registrador", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///   
        ///   
        ///   
        ///entity ROM is 
        ///  Generic ( 
        ///      p_ADD_WIDTH    : INTEGER := 9; 
        ///      p_DATA_WIDTH   : INTEGER := 16 
        ///  ); 
        ///  Port ( 
        ///      i_CLK	   : in STD_LOGIC; 
        ///      i_RST	   : in STD_LOGIC; 
        ///      i_EN_CLK	   : in STD_LOGIC; 
        ///      i_EN 	   : in STD_LOGIC; 
        ///      i_ADDRESS      : in STD_LOGIC_VECTOR ((p_ADD_WIDTH-1) downto 0); 
        ///      o_DOUT         : out STD_LOGIC_VECTOR ((p_DATA_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string rom {
            get {
                return ResourceManager.GetString("rom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LIBRARY ieee;
        ///USE ieee.std_logic_1164.all;
        ///
        ///LIBRARY altera_mf;
        ///USE altera_mf.all;
        ///
        ///ENTITY sram IS
        ///	PORT
        ///	(
        ///		aclr		: IN STD_LOGIC  := &apos;0&apos;;
        ///		address		: IN STD_LOGIC_VECTOR (8 DOWNTO 0);
        ///		clock		: IN STD_LOGIC  := &apos;1&apos;;
        ///		data		: IN STD_LOGIC_VECTOR (15 DOWNTO 0);
        ///		wren		: IN STD_LOGIC ;
        ///		q		: OUT STD_LOGIC_VECTOR (15 DOWNTO 0)
        ///	);
        ///END sram;
        ///
        ///
        ///ARCHITECTURE SYN OF sram IS
        ///
        ///	SIGNAL sub_wire0	: STD_LOGIC_VECTOR (15 DOWNTO 0);
        ///
        ///
        ///
        ///	COMPONENT altsyncram
        ///	GENERIC (
        ///		clock_enable_input_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string sram {
            get {
                return ResourceManager.GetString("sram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to alo
        ///alo
        ///alo
        ///ue
        ///adsnfkdsnf]dknfnad
        ///dnnlksdfnlksdf.
        /// </summary>
        internal static string teste {
            get {
                return ResourceManager.GetString("teste", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to library IEEE;
        ///use IEEE.STD_LOGIC_1164.ALL;
        ///use IEEE.STD_LOGIC_ARITH.ALL;
        ///use IEEE.STD_LOGIC_UNSIGNED.ALL;
        ///
        ///
        ///entity ULA is
        ///    Generic(
        ///			p_DATA_WIDTH    : INTEGER := 16
        ///	 );	
        ///    Port ( 
        ///			i_REG_S1		: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	  
        ///			i_REG_S2		: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	
        ///			i_SEL_ULA   	: in  STD_LOGIC_VECTOR(2 DOWNTO 0);	
        ///			o_DATA_ULA	: out  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0)
        ///	 );
        ///end ULA;
        ///
        ///architecture Behavioral of ULA is
        ///
        ///	
        ///b [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ula {
            get {
                return ResourceManager.GetString("ula", resourceCulture);
            }
        }
    }
}