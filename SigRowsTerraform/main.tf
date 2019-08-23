provider "azurerm" {
  version = "=2.0.0"
}

module "SIG_Rows" {
  source=""
  version = "0.1"
}
resource "azurerm_resource_group" "SIG_Rows_RG" {
  name = "${var.resource_name}"
  location = "${var.location}"
}

resource "azurerm_sql_server" "SIG_Rows_SqlServerDB" {
  name = "SIG_Rows_SqlServerDB"
  resource_group_name = "${var.resource_name}"
  location = "${var.location}"
  version = "12.0"
  administrator_login = "${var.User_Database}"
  administrator_login_password = "${var.Password_Database}" 
}






