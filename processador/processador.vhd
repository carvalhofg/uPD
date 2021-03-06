library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.STD_LOGIC_ARITH.ALL;
use IEEE.STD_LOGIC_UNSIGNED.ALL;


entity PROCESSADOR is
	 Generic(
	 		p_DATA_WIDTH   : INTEGER := 16;        -- Número de bits dos dados. 
	 		p_ADD_WIDTH    : INTEGER := 9         -- Número de bits dos endereços. 
	 );
   Port ( 
				i_CLK		: in  STD_LOGIC;
				i_RST		: in  STD_LOGIC;
				
				o_EN_CLK	: out STD_LOGIC;
				o_EN_ROM	: out STD_LOGIC;
				i_DATA_ROM	: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	  
				o_ADD_ROM	: out STD_LOGIC_VECTOR(10 DOWNTO 0);
				
				o_WR_IO    	: out STD_LOGIC;
				o_RD_IO		: out STD_LOGIC;				
				i_DATA_IO	: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);
				o_DATA_IO	: out STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);
				o_ADDR_IO   : out STD_LOGIC_VECTOR((p_DATA_WIDTH-8) DOWNTO 0);

				i_INT0		: in  STD_LOGIC;
				i_INT1		: in  STD_LOGIC;
				i_INT2		: in  STD_LOGIC;
				o_BUSY      : out STD_LOGIC						
	 );
end PROCESSADOR;

architecture Behavioral of PROCESSADOR is
-----------------------------------------------------------------

	COMPONENT CAMINHO_CONTROLE is
	 Generic(
				p_DATA_WIDTH   : INTEGER := 16;        -- Número de bits dos dados. 
				p_ADD_WIDTH    : INTEGER := 9         -- Número de bits dos endereços. 
	 );
     Port ( 
				i_CLK			: in  STD_LOGIC;
				i_RST			: in  STD_LOGIC;
				
				i_DATA_ROM		: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);	  
				i_DATA_ULA		: in  STD_LOGIC;
				o_SEL_ULA		: out STD_LOGIC_VECTOR(2 DOWNTO 0);	
				o_SEL_IMED		: out STD_LOGIC_VECTOR(1 DOWNTO 0);	
			     o_WR_BCO      	: out STD_LOGIC;
				o_WR_RAM      	: out STD_LOGIC;
				o_WR_IO       	: out STD_LOGIC;
				o_RD_IO			: out STD_LOGIC;
				o_EN_ROM		: out STD_LOGIC;
				o_ADD_ROM		: out STD_LOGIC_VECTOR(10 DOWNTO 0);
				o_DATA			: out STD_LOGIC_VECTOR(10 DOWNTO 0);
				o_EN_CLK		: out STD_LOGIC;
				
				o_RET		: out STD_LOGIC;
				o_DOUT_LIFO : out STD_LOGIC_VECTOR(63 DOWNTO 0);
				i_DIN_LIFO  : in  STD_LOGIC_VECTOR(63 DOWNTO 0);
				
				i_INT0		: in  STD_LOGIC;
				i_INT1		: in  STD_LOGIC;
				i_INT2		: in  STD_LOGIC;
				o_BUSY      : out STD_LOGIC						
	 );
	end COMPONENT;

	COMPONENT CAMINHO_DADOS is
	 Generic (
				p_DATA_WIDTH	: INTEGER := 16
	 );
      Port ( 
				i_CLK			: in  STD_LOGIC;
				i_RST			: in  STD_LOGIC;
				i_DATA			: in  STD_LOGIC_VECTOR(10 DOWNTO 0);	  
				i_SEL_ULA		: in  STD_LOGIC_VECTOR(2 DOWNTO 0);	
				i_SEL_IMED		: in  STD_LOGIC_VECTOR(1 DOWNTO 0);
				i_WR_BCO		: in  STD_LOGIC;
				i_WR_RAM    	: in  STD_LOGIC;
				i_WR_IO       	: in  STD_LOGIC;
				i_RD_IO       	: in  STD_LOGIC;
				i_DATA_IO		: in  STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);
				o_DATA_ULA		: out STD_LOGIC;				
				o_DATA_IO		: out STD_LOGIC_VECTOR((p_DATA_WIDTH-1) DOWNTO 0);
				o_ADDR_IO      	: out STD_LOGIC_VECTOR((p_DATA_WIDTH-8) DOWNTO 0);
				
				i_RET			: in  STD_LOGIC;
				i_DOUT_LIFO 	: in  STD_LOGIC_VECTOR(63 DOWNTO 0);
				o_DIN_LIFO  	: out STD_LOGIC_VECTOR(63 DOWNTO 0)					
	 );
	end COMPONENT;

	signal   w_SEL_IMED : STD_LOGIC_VECTOR(1 DOWNTO 0);
	signal   w_WR_BCO  	: STD_LOGIC;
	signal   w_WR_RAM  	: STD_LOGIC;
	signal   w_SEL_ULA	: STD_LOGIC_VECTOR(2 DOWNTO 0);
	signal   w_WR_IO   	: STD_LOGIC;
	signal   w_RD_IO   	: STD_LOGIC;
	signal   w_DATA_ULA : STD_LOGIC;
	signal   w_DATA		: STD_LOGIC_VECTOR(10 DOWNTO 0);

	signal 	w_RET		: STD_LOGIC;
	signal 	w_DOUT_LIFO : STD_LOGIC_VECTOR(63 DOWNTO 0);
	signal 	w_DIN_LIFO  : STD_LOGIC_VECTOR(63 DOWNTO 0);	
				
-----------------------------------------------------------------	
begin
	
	--
	-- Sinais de controle de I/O.
	--
	o_WR_IO <= w_WR_IO;
	o_RD_IO <= w_RD_IO;
	
	
	CC : CAMINHO_CONTROLE 
	  Generic Map(
					p_DATA_WIDTH 	=> p_DATA_WIDTH,
					p_ADD_WIDTH     => p_ADD_WIDTH
	  )
      Port Map ( 
					i_CLK			=> i_CLK,
					i_RST			=> i_RST,		
					i_DATA_ROM		=> i_DATA_ROM,
					i_DATA_ULA     	=> w_DATA_ULA,
					o_SEL_ULA		=> w_SEL_ULA,
					o_SEL_IMED		=> w_SEL_IMED,
					o_WR_BCO      	=> w_WR_BCO,
					o_WR_RAM		=> w_WR_RAM,
					o_WR_IO       	=> w_WR_IO,
					o_RD_IO			=> w_RD_IO,
					o_EN_ROM		=> o_EN_ROM,
					o_ADD_ROM		=> o_ADD_ROM,
					o_DATA			=> w_DATA,
					o_EN_CLK		=> o_EN_CLK,
				
					o_RET			=> w_RET,
					o_DOUT_LIFO 	=> w_DOUT_LIFO,
					i_DIN_LIFO  	=> w_DIN_LIFO,
					
					i_INT0			=> i_INT0,
					i_INT1			=> i_INT1,
					i_INT2			=> i_INT2,
					o_BUSY      	=> o_BUSY
	 );
	
	CD : CAMINHO_DADOS 
	 Generic Map(
					p_DATA_WIDTH 	=> p_DATA_WIDTH
	 )
      Port Map ( 
					i_CLK			=> i_CLK,
					i_RST			=> i_RST,
					i_DATA			=> w_DATA,
					i_SEL_ULA		=> w_SEL_ULA,
					i_SEL_IMED		=> w_SEL_IMED,
					i_WR_BCO      	=> w_WR_BCO,
					i_WR_RAM		=> w_WR_RAM,
					i_WR_IO       	=> w_WR_IO,
					i_RD_IO			=> w_RD_IO,
					i_DATA_IO      	=> i_DATA_IO,
					o_DATA_ULA		=> w_DATA_ULA,
					o_DATA_IO		=> o_DATA_IO,
					o_ADDR_IO      	=> o_ADDR_IO,
				
					i_RET			=> w_RET,
					i_DOUT_LIFO 	=> w_DOUT_LIFO,
					o_DIN_LIFO  	=> w_DIN_LIFO
	 );
	

end behavioral;