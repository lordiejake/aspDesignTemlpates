<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="PostWEB.aspx.cs" Inherits="PostWEB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Welcome to Duldulao Forums</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <script type="text/javascript">
    function LoadImage(path, img) {
        imgPrev = document.images[img];
        imgPrev.src = path;
        }
</script>
    <style type="text/css">
        #fleUpload
        {
            width: 359px;
        }
        .Gridview
        {
            margin-right: 1px;
        }
        .style1
        {
            height: 30px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
		
			<div id="logo">
				<h1> &nbsp;</h1>
			</div>		
			
			<div id="menu">
				<ul>
					<li><a href="#">Home</a>
					    <ul>
					        <li><a href="#">CENCOM blogs</a></li>
					        <li><a href="#">CAS blogs</a></li>
					        <li><a href="#">CED blogs</a></li>
					        <li><a href="#">CN blogs</a></li>
					        <li><a href="#">CBDEM blogs</a></li>
		                    <li><a href="#">CHEFS blogs</a></li>
		   	                <li><a href="#">CIT blogs</a></li>
					    </ul>
					</li>
					    
					<li><a href="#">Contact us</a>
					     <ul>
					        <li><a href="#">Telephone #</a></li>
					        <li><a href="#">Cellphone #</a></li>
					        <li><a href="#">Email Address</a></li>
					        <li><a href="#">Location</a></li>
					
					    </ul>
					</li>
					<li><a href="#">Services</a>
					     <ul>
					        <li><a href="#">Programming Tutorials</a></li>
					        <li><a href="#">Solving Tutorials</a></li>
					        <li><a href="#">Chemistry Tutorials</a></li>
					        <li><a href="#">WEB tutorials</a></li>
					        <li><a href="#">Guitar tutorials</a></li>
		                    <li><a href="#">Piano Tutorials</a></li>
		   	                <li><a href="#">Drums Tutorials</a></li>
					    </ul>
					</li>
					<li><a href="#">Sign-OUT</a>
					     <ul>
					        <li><a href="loginForm.aspx">Log-out</a></li>
					    </ul>
					</li>
					<li><a href="#">Information</a>
					     <ul>
					        <li><a href="#">CENCOM blogs</a></li>
					        <li><a href="#">CAS blogs</a></li>
					        <li><a href="#">CED blogs</a></li>
					        <li><a href="#">CN blogs</a></li>
					        <li><a href="#">CBDEM blogs</a></li>
		                    <li><a href="#">CHEFS blogs</a></li>
		   	                <li><a href="#">CIT blogs</a></li>
		   	                
					    </ul>
					</li>
				</ul>
			</div>
		</div>
		
		<div id="logx">
		   
		   <h4>Csharp Forums: Welcome:  
               <asp:Label ID="lblwelcome" runat="server" Text="Label"></asp:Label> 
               <asp:Label ID="LabelIDS" runat="server" Text="Label" Visible="False"></asp:Label> Email Address: 
               <asp:Label ID="LabelEmails" runat="server" Text="Label"></asp:Label>
               
               <asp:Label ID="LabelThreadID" runat="server" Visible="False"></asp:Label>
               <asp:Label ID="lblIDEN" runat="server" Visible="False"></asp:Label>
               <asp:Label ID="lblTopics" runat="server" Visible="False"></asp:Label></h4>
		   <div id = "part">
		   <img alt="" src="orange-circuit940x198.jpg" 
                    style="width: 501px; height: 110px" /><img alt="" src="orange-circuit940x198.jpg" 
                    style="width: 457px; height: 110px" /></div>
		   </div>
		   
		   <div id = "part2">
		    </div>          
		</div>
	<div id="wrapper">
		<div id="page">
		<div id="page-bg">
			<div id="sidebar1" class="sidebar">
				<ul>
					
					<li>
					<h2>Related Forums</h2>
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="loginForm.aspx">asp.net Class w/ forum</a></li><hr id="hz"/>
							<li><a href="#">asp.net design w/ forum</a></li><hr id="hz"/>
							<li><a href="#">asp.net Toolbox w/ forum</a></li><hr id="hz"/>
							<li><a href="#">Databases w/ forum</a></li><hr id="hz"/>
							<li><a href="#">MSSQL tutorials w/ forum</a></li><hr id="hz"/>
							<li><a href="#">SQL Querries w/ forum</a></li><hr id="hz"/>
							<li><a href="#">SQL Injection w/ forum</a></li><hr id="hz"/>
							<li><a href="#">asp.net Function w/ forum</a></li><hr id="hz"/>
							<li><a href="#">WEB asp.net w/ forum</a></li><hr id="hz"/>
							<li><a href="#">Datatypes w/ forum</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					<li>
					<h2>Related Topics</h2>
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="#">About css</a></li><hr id="hz"/>
							<li><a href="#">About javascript</a></li><hr id="hz"/>
							<li><a href="#">About HTML</a></li><hr id="hz"/>
							<li><a href="#">About PHP</a></li><hr id="hz"/>
							<li><a href="#">About c++</a></li><hr id="hz"/>
							<li><a href="#">About f#</a></li><hr id="hz"/>
							<li><a href="#">About C</a></li><hr id="hz"/>
							<li><a href="#">About Joomla</a></li><hr id="hz"/>
							<li><a href="#">About Drupal</a></li><hr id="hz"/>
							<li><a href="#">About WordPress</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					<li>
					<h2>Programming Languages</h2>
					<br /><br />
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="#">Visual C#</a></li><hr id="hz"/>
							<li><a href="#">Visual F#</a></li><hr id="hz"/>
							<li><a href="#">C++</a></li><hr id="hz"/>
							<li><a href="#">Java</a></li><hr id="hz"/>
							<li><a href="#">Fortran</a></li><hr id="hz"/>
							<li><a href="#">Foxpro</a></li><hr id="hz"/>
							<li><a href="#">Lisp</a></li><hr id="hz"/>
							<li><a href="#">Drupal</a></li><hr id="hz"/>
							<li><a href="#">Clojure</a></li><hr id="hz"/>
							<li><a href="#">Go</a></li><hr id="hz"/>
							<li><a href="#">Perl</a></li><hr id="hz"/>
							<li><a href="#">Phyton</a></li><hr id="hz"/>
							<li><a href="#">SmallTalk</a></li><hr id="hz"/>
							<li><a href="#">Prolog</a></li><hr id="hz"/>
							<li><a href="#">Cobol</a></li><hr id="hz"/>
							<li><a href="#">C ProgrammingL</a></li><hr id="hz"/>
							<li><a href="#">Visual Basic</a></li><hr id="hz"/>
							<li><a href="#">Drupal</a></li><hr id="hz"/>
							<li><a href="#">Clojure</a></li><hr id="hz"/>
							<li><a href="#">Go</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					
				</ul>
			</div>
			
			
			
			
		<div id="contenting">
			
			<div class="post">
				<h1 class="title"><a href="#">Replies</h1>
			</div>
			<hr />
			<br />
			<div>
			    <table>
			        <tr>
			            <td> <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">---[Back]Category Page</asp:LinkButton> </td> <td></td><td><asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">---[Back]Topic Page</asp:LinkButton></td><td></td><td><asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">---[Back]Thread Page</asp:LinkButton></td>
			        </tr>
			    </table>
                </div>
		
		<div>
		    <h2 class="title"><a href="#">c# Tutorials Objectives</a></h2>
				<p class="byline"><small><a href="#"> Duldulao Jake </a>: WEB administrator</small></p>
				<div class="entry">
					<p>•	To emphasize the importance of learning C# asp.net.</p>
					<p>•	To clarify things specially when it comes to coding techniques.</p>
					<p>•	To develop our skills in programming techniques..</p>
					<p>•	Sharing of knowledge and ideas about specific topic.</p>
				</div>
		</div>
		
		<hr />
			
			<div>
			    <fieldset id = "threadconfig">
			        
			    </fieldset>
			</div>
			
			<hr />
			    <div>
                    <asp:GridView ID="ThreadNo" runat="server" AutoGenerateColumns="False" 
                        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                        CellPadding="4" Font-Size="Large" ForeColor="Black" 
                        Width="703px" CellSpacing="2">
                        <RowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ThreadTopic" 
                                HeaderText="Thread:------" >
                                <ItemStyle BorderStyle="Inset" Font-Size="X-Large" Font-Underline="True" 
                                    ForeColor="#333333" HorizontalAlign="Left" VerticalAlign="Top" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" 
                            HorizontalAlign="Left" VerticalAlign="Top" Wrap="True" />
                    </asp:GridView>
			    </div>
			<hr />
			<div>
			    <table>
			        <tr>
			            <td>By: </td><td>  <asp:HyperLink ID="linkby" runat="server"></asp:HyperLink> </td>
			        </tr>
			    </table>
			</div>
			<div>
			    &nbsp;</div>
			<br />
			
			<div>
			    <table>
			        <tr>
			            <td><asp:HyperLink ID="HyperCategory" runat="server">Go Back to Category Page</asp:HyperLink></td><td> </td>
			            <td> 
                            <asp:HyperLink ID="HyperTopics" runat="server">Go Back to Topic Page</asp:HyperLink></td><td> </td>
			            <td> <asp:HyperLink ID="HyperThreads" runat="server">Go Back to Thread Page</asp:HyperLink> </td>
			             
			        </tr>
			    </table> 
			 </div>
            <br />
			<div>
			    <fieldset id = "threadconfig">
			        
			    </fieldset>
			</div>
			
			
			
			<div class="post">
				<div class="entry">
				</div>
			</div>
			
			<div>
			    <h2 class="title"><a href="#">Answer&gt;&gt;&gt;(Comments/Replies:)</a></h2>
			</div>
			<div>
                <asp:Label ID="PostsStatus" runat="server" Font-Bold="True" Font-Size="Large" 
                    Font-Underline="True"></asp:Label>
			</div>
			<hr />
			<div style="width: 684px">
                    <asp:GridView ID="Posting" runat="server" AutoGenerateColumns="False" 
                    CellPadding="10" Font-Size="Small" ForeColor="#333333" GridLines="None" 
                    Width="703px" HorizontalAlign="Justify">
                        <RowStyle BackColor="#E3EAEB" BorderStyle="Double" />
                        <Columns>
                            <asp:BoundField DataField="userzx" HeaderText="Name_(Account)" >
                                <HeaderStyle BorderStyle="Double" />
                                <ItemStyle BackColor="#FFFFCC" BorderStyle="Groove" Font-Bold="True" 
                                    HorizontalAlign="Left" VerticalAlign="Top" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Post" HeaderText="Comment/s(Post/s)" >
                                <ControlStyle BorderStyle="Double" />
                                <HeaderStyle BorderStyle="Double" />
                                <ItemStyle HorizontalAlign="Center" Wrap="True" BorderStyle="Groove" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PostDate" HeaderText="Date" >
                                <HeaderStyle BorderStyle="Double" />
                                <ItemStyle BackColor="#FFFFCC" Font-Italic="True" BorderStyle="Groove" 
                                    HorizontalAlign="Left" VerticalAlign="Top" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" 
                            BorderStyle="Solid" VerticalAlign="Top" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" 
                            BorderStyle="Solid" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" 
                            HorizontalAlign="Left" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
			</div>
        <hr />
      
      <div>
        
                    <asp:GridView ID="Posting0" runat="server" AutoGenerateColumns="False" 
                    CellPadding="10" Font-Size="Small" ForeColor="#333333" GridLines="None" 
                    Width="703px" HorizontalAlign="Justify">
                        <RowStyle BackColor="#E3EAEB" BorderStyle="Double" />
                        <Columns>
                            <asp:BoundField DataField="userzx" HeaderText="Name_(Account)" >
                                <HeaderStyle BorderStyle="Double" />
                                <ItemStyle BackColor="#FFFFCC" BorderStyle="Groove" Font-Bold="True" 
                                    HorizontalAlign="Left" VerticalAlign="Top" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Post" HeaderText="Comment/s(Post/s)" >
                                <ControlStyle BorderStyle="Double" />
                                <HeaderStyle BorderStyle="Double" />
                                <ItemStyle HorizontalAlign="Center" Wrap="True" BorderStyle="Groove" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PostDate" HeaderText="Date" >
                                <HeaderStyle BorderStyle="Double" />
                                <ItemStyle BackColor="#FFFFCC" Font-Italic="True" BorderStyle="Groove" 
                                    HorizontalAlign="Left" VerticalAlign="Top" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" 
                            BorderStyle="Solid" VerticalAlign="Top" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" 
                            BorderStyle="Solid" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" 
                            HorizontalAlign="Left" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
        
      </div>
      
        <div>
            <table>
                <tr>
                    <td></td><td>  <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label></td>
                </tr>
                <tr>
                    <td></td><td> <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label> </td>
                </tr>
            </table>
        </div>
        <div>
	     <fieldset id = "threadconfig">
			        
	    </fieldset>
	    </div>
	    
	    <div>
            <asp:Label ID="Label1" runat="server" Text="Post: ANSWER"></asp:Label>
	    <table style="height: 83px">
	     
	        <tr>
	            <td> <fieldset>
                  <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="672px" 
                        Height="197px" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
	                </fieldset> </td>
	              
	        </tr>
	        <tr>
	            <td class="style1"> 
                    <asp:Button ID="Button1" runat="server" Text="Submit(Post)" 
                        onclick="Button1_Click" style="height: 26px" Width="197px" /> </td>           
	        </tr>
	      
	      <tr>
	        <td>
	             <asp:Label ID="Resulting" runat="server" Text=""></asp:Label>
	        </td>
	      </tr>
	    </table>
	    </div>
	    
	    <div>
	     <fieldset id = "threadconfig">
           
	    </fieldset>
	    </div>
			
		</div>
		
		
		
		
			<div style="clear: both;">&nbsp;</div>
		</div>
		
		
		
		
	</div>
	
	<div id="footer">
        <div id="footer-bg">
	            <p class="copyright">&copy;&nbsp;&nbsp;2009 All Rights Reserved &nbsp;&bull;&nbsp; Design by  Jake V.</a>.</p>
	            <p class="link">&nbsp;</p>
        </div>
    </div>
    </form>
</body>
</html>
