<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="ThreadsFormbyTOPIC.aspx.cs" Inherits="ThreadsFormbyTOPIC" %>

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
               <asp:Label ID="lblIDEN" runat="server" Visible="False"></asp:Label></h4>
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
			
			
			
			
		<div id="content">
		
		<div class="post">
				<h1 class="title"><a href="#">Threads</h1>
			</div>
			
			<br />
			<div>
			    <table>
			        <tr>
			            <td> <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">---[Back]Category Page</asp:LinkButton> </td> <td></td><td><asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">---[Back]Topic Page</asp:LinkButton></td>
			        </tr>
			    </table>
                </div>
		<hr />
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
		
			<div class="post">
				<h1 class="title"><a href="#">Welcome to c# Tutorials</a></h1>
			</div>
			<hr />
			
			<div>
			    <fieldset id = "threadconfig">
			        
			    </fieldset>
			</div>
			
			<br />
			
			<div>
			    <fieldset>
                    <asp:GridView ID="GridTopic" runat="server" AutoGenerateColumns="False" 
                        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Ridge" BorderWidth="3px" 
                        CellPadding="4" CellSpacing="2" Font-Bold="False" Font-Italic="False" 
                        Font-Overline="False" Font-Size="Large" ForeColor="#333333" ShowHeader="False" 
                        Width="433px">
                        <RowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="TopicDecription" HeaderText="Topic" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
			    </fieldset>
			</div>
            <br />
			<div>
			    <fieldset id = "threadconfig">
			        
			    </fieldset>
			</div>
			
			<br />
			<br />
			<hr />
			<br />
			    <div>
                    <asp:Label ID="lblALLTHREADS" runat="server" Text="Label" Font-Bold="True" 
                                    Font-Size="Large" Font-Underline="True" ForeColor="#009900"></asp:Label>
			    </div>
		     <br />
			<hr />
			
			<div>
			    <h2 class="title"><a href="#">List of Threads(w/ Replies)</a></h2>
			</div>
			    <div>
                    <asp:Label ID="txtThreadsWITHreplies" runat="server" Text="Label" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="True"></asp:Label></div>
			<br />
			<div>
                <asp:GridView ID="ThreadsAvailable" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" Font-Size="Small" ForeColor="#333333" Width="461px" 
                    onrowcommand="ThreadsAvailable_RowCommand">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:BoundField DataField="ThreadID" HeaderText="Code" />
                        <asp:BoundField DataField="ThreadTopic" HeaderText="Thread/s">
                            <ItemStyle Font-Underline="True" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Posts" HeaderText="Replies" />
                        <asp:BoundField DataField="ThreadViewCount" HeaderText="Views" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
			</div>
			<br /><br /><br />
			<hr />
		<div>
		    <h2 class="title"><a href="#">List of Threads(w/ 0 Replies)</a></h2>
		</div>
		<div>
                    <asp:Label ID="txtThreadsWITHoutreplies" runat="server" Text="Label" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="True"></asp:Label></div>
			<br />
        <div>
                <asp:GridView ID="ThreadsnotAvailablezzz" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" Font-Size="Small" ForeColor="#333333" Width="460px" 
                    onrowcommand="ThreadsnotAvailablezzz_RowCommand">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:BoundField DataField="ThreadID" HeaderText="Code" />
                        <asp:BoundField DataField="ThreadTopic" HeaderText="Thread/s">
                            <ItemStyle Font-Underline="True" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ThreadStatus" HeaderText="Replies" />
                        <asp:BoundField DataField="ThreadViewCount" HeaderText="Views" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <br />
        </div>
        <hr />
      <div>
        
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
              onrowcommand="GridView1_RowCommand">
              <Columns>
                  <asp:BoundField DataField="ThreadID" HeaderText="Code" />
                  <asp:BoundField DataField="ThreadTopic" HeaderText="Thread" />
                  <asp:BoundField DataField="ThreadStatus" HeaderText="Status" />
                  <asp:BoundField DataField="ThreadViewCount" HeaderText="ThreadViewCount" />
                  <asp:CommandField ShowSelectButton="True" />
              </Columns>
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
                 <tr>
                    <td> <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label> </td><td> <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label> 
                     <br />
                     </td>
                </tr>
            </table>
        </div>
        <div>
	     <fieldset id = "threadconfig">
			        
	    </fieldset>
	    </div>
	    
	    <div>
            <asp:Label ID="Label1" runat="server" Text="Add Question here(Threads)"></asp:Label>
	    <table style="height: 83px">
	     
	        <tr>
	            <td> <fieldset>
                  <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="446px" 
                        Height="125px" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
	                </fieldset> </td>
	              
	        </tr>
	        <tr>
	            <td> 
                    <asp:Button ID="Button1" runat="server" Text="Submit(New Thread)" 
                        onclick="Button1_Click" style="height: 26px" /> </td>           
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
		
		
		
		
		<div id="sidebar2" class="sidebarb">
				<ul>

					
					<li>
					<h2>Schools with ASP.NET(Philippines)</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">USM</a></li><hr id="Hr2"/>
							<li><a href="#">UP Diliman</a></li><hr id="Hr3"/>
							<li><a href="#">UP Los Banos</a></li><hr id="Hr4"/>
							<li><a href="#">UP Davao</a></li><hr id="Hr5"/>
							<li><a href="#">USEP</a></li><hr id="Hr6"/>
							<li><a href="#">ADMU</a></li><hr id="Hr7"/>
							<li><a href="#">ADDU</a></li><hr id="Hr8"/>
							<li><a href="#">NDKC</a></li><hr id="Hr9"/>
							<li><a href="#">NDMC</a></li><hr id="Hr10"/>
							<li><a href="#">NDDU</a></li><hr id="Hr11"/>
							<li><a href="#">USM</a></li><hr id="Hr1"/>
							<li><a href="#">UP Diliman</a></li><hr id="Hr12"/>
							<li><a href="#">UP Los Banos</a></li><hr id="Hr13"/>
							<li><a href="#">UP Davao</a></li><hr id="Hr14"/>
							<li><a href="#">USEP</a></li><hr id="Hr15"/>
							<li><a href="#">ADMU</a></li><hr id="Hr16"/>
							<li><a href="#">ADDU</a></li><hr id="Hr17"/>
							<li><a href="#">NDKC</a></li><hr id="Hr18"/>
							<li><a href="#">NDMC</a></li><hr id="Hr19"/>
							<li><a href="#">NDDU</a></li><hr id="Hr20"/>
						</ul>
						</div>
					</li>
					<li>
					<h2>Most Visited Sites</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">www.facebook.com</a></li>
							<li><a href="#">www.twitter.com</a></li>
							<li><a href="#">www.yahoo.com</a></li>
							<li><a href="#">www.google.com</a></li>
							<li><a href="#">www.toutube.com</a></li>
							<li><a href="#">www.asp-net.com</a></li>
							<li><a href="#">www.joomla.com</a></li>
							<li><a href="#">www.php.com</a></li>
							<li><a href="#">www.drupal.com</a></li>
							<li><a href="#">www.csharp.com</a></li>
						</ul>
						</div>
					</li>
					
					<li>
					<h2>System(Desktop c# asp.net)</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">Ordering System</a></li>
							<li><a href="#">Library System</a></li>
							<li><a href="#">Reservation System</a></li>
							<li><a href="#">Enrollment System</a></li>
							<li><a href="#">Accounting System</a></li>
							<li><a href="#">Delivery System</a></li>
							<li><a href="#">Information System</a></li>
							<li><a href="#">Order management System</a></li>
							<li><a href="#">Log on System</a></li>
							<li><a href="#">Barcoding System</a></li>
						</ul>
						</div>
					</li>
					
					<li>
					<h2>System(WEB c# asp.net)</h2>
					    <div id="Sides2">
						<ul>
							<li><a href="#">Ordering System</a></li>
							<li><a href="#">Library System</a></li>
							<li><a href="#">Reservation System</a></li>
							<li><a href="#">Enrollment System</a></li>
							<li><a href="#">Accounting System</a></li>
							<li><a href="#">Delivery System</a></li>
							<li><a href="#">Information System</a></li>
							<li><a href="#">Order management System</a></li>
							<li><a href="#">Log on System</a></li>
							<li><a href="#">Barcoding System</a></li>
						</ul>
						</div>
					</li>
				
					
					
					
				</ul>
			</div>
			<div style="clear: both;">&nbsp;</div>
		</div>
		</div>
		
		
		
		
	</div>
	
	<div id="footer">
        <div id="footer-bg">
	            <p class="copyright">&copy;&nbsp;&nbsp;2009 All Rights Reserved &nbsp;&bull;&nbsp; Design by <a href="#">Duldulao Jake V.</a>.</p>
	            <p class="link">&nbsp;</p>
        </div>
    </div>
    <div style="text-align: center; font-size: 0.75em;"></div>
    </form>
</body>
</html>
