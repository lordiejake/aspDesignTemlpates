<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="loginForm.aspx.cs" Inherits="loginForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Log in Form</title>
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
					<li><a href="#">Register</a>
					     <ul>
					        <li><a href="loginForm.aspx">Online Registration</a></li>
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
		<h4>Csharp Forums: Welcome:  <asp:Label ID="LoginPerson" runat="server" Text=""></asp:Label> </h4> 
		   
		   <div id = "part">
		   <img alt="" src="orange-circuit940x198.jpg" 
                    style="width: 501px; height: 110px" /><img alt="" src="orange-circuit940x198.jpg" 
                    style="width: 457px; height: 110px" /></div>
		   </div>
		   
		   <div id = "part2">
		    </div>
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
							<li><a href="#">asp.net Class w/ forum</a></li><hr id="hz"/>
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
					<br />
					    <div>
					            <table>
					                  <tr>
					                        <td><h2>Administrator:</h2></td>
					                  </tr>
					                  <tr>
					                        <td><asp:TextBox ID="txtadminusername" runat="server"></asp:TextBox>&lt;&lt;Admin</td>
					                  </tr>
					                  <tr>
					                        <td><asp:TextBox ID="txtadminpassword" runat="server" TextMode="Password"></asp:TextBox>
                                                &lt;&lt;Password</td>
					                  </tr>
					                  <tr>
					                        <td><asp:Button ID="LogInAdmin" runat="server" Text="Log-In" 
                                                    onclick="LogInAdmin_Click" /></td>
					                  </tr>
					                  <tr>
					                        <td><asp:Label ID="AdminStatus" runat="server" Text=""></asp:Label> </td>
					                  </tr>
					            </table>
					    </div>
					<br />
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
				<h1 class="title"><a href="#">LOG-IN</h1>
			</div>
		<hr />
		<div class="post">
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
				<h1 class="title"><a href="#">Log IN Form</h1>
			</div>
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			
			<hr />
			<div>
			    <fieldset>
			        <table>
			            <tr>
			                <td>User Name</td>
			                <td><asp:TextBox ID="LogName" runat="server" Width="302px"></asp:TextBox></td>
			            </tr>
			             <tr>
			                <td>Password</td>
			                <td><asp:TextBox ID="pass" runat="server" Width="302px" TextMode="Password"></asp:TextBox></td>
			            </tr>
			            <tr>
			                <td></td>
			                <td>
                                <asp:Button ID="login" runat="server" Text="Log IN&gt;&gt;" Width="202px" 
                                    onclick="login_Click"/></td>
			            </tr>
			            <tr>
			                <td></td>
			                <td>
                                <asp:Label ID="succes" runat="server" Text=""></asp:Label></td>
			            </tr>
			        </table>
			    </fieldset>
			</div>
			<hr />
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			<div class="post">
				<h1 class="title"><a href="#">Sign UP Form</a></h1>
			</div>
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
		    <hr />
		    <div>
		    <fieldset>
		         <table> 
		            <tr>
		                <td>Last Name:</td>
		                <td><asp:TextBox ID="TextLN" runat="server" Width="302px"></asp:TextBox></td>
		            </tr>
		            <tr>
		                <td>First Name:</td>
		                <td><asp:TextBox ID="TextFN" runat="server" Width="302px" ></asp:TextBox></td>
		            </tr>
		            <tr>
		                <td>User Name:</td>
		                <td><asp:TextBox ID="TextUN" runat="server" Width="302px"></asp:TextBox></td>
		            </tr>
		            <tr>
		                <td>Password:</td>
		                <td><asp:TextBox ID="TextPASS" runat="server" TextMode="Password" Width="269px"></asp:TextBox></td>
		            </tr>
		            <tr>
		                <td>Email:</td>
		                <td><asp:TextBox ID="TextEmail" runat="server" Width="302px"></asp:TextBox></td>
		            </tr>
		            <tr>
		                <td></td>
		                <td><asp:Button ID="BtnSubmitt" runat="server" Text="Submit>>" Width="202px" 
                                onclick="BtnSubmitt_Click1" /></td>
		            </tr>
		            <tr>
		                <td></td>
		                <td><asp:Label ID="Resultdz" runat="server" Text=""></asp:Label></td>
		            </tr>
		            <tr>
		                <td></td>
		                <td><asp:Label ID="Sendmailsz" runat="server" Text=""></asp:Label></td>
		            </tr>
		        </table>
		    </fieldset>
		    </div>
		    <hr />
		    <div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			<div>
			    <hr />
			    <br />
			        <div>
                        <asp:Label ID="lblViewMembers" runat="server" Font-Bold="True" 
                            Font-Size="Large" Font-Underline="True" ForeColor="#006600"></asp:Label></div>
			    <br />
			    <hr />
			    <fieldset id = "anounce">
			        <table>
			            <tr>
			                <td>
			                <div id = "fg" style="overflow: auto; height:300px";>
			                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                                    CellPadding="4" ForeColor="Black" Width="423px" Height="151px" 
                                    HorizontalAlign="Left" ShowFooter="True" style="font-style: italic">
                                    <Columns>
                                        <asp:BoundField DataField="Names" HeaderText="Name" >
                                            <ItemStyle Font-Bold="True" Font-Italic="True" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="EmailAddressz" HeaderText="EmailAddress" />
                                    </Columns>
                                    <FooterStyle BackColor="#333333" ForeColor="Black" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" 
                                        HorizontalAlign="Left" VerticalAlign="Top" />
                                    <AlternatingRowStyle BackColor="Silver" />
                                </asp:GridView>
			                </div>
                                
                            </td>
			            </tr>
			        </table>
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
	    .</p>
	            <p class="link">&nbsp;</p>
        </div>
    </div>
    <div style="text-align: center; font-size: 0.75em;"></div>
    </form>
</body>
</html>
