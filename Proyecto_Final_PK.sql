SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Proyecto_Final_Gerald_Castro` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Proyecto_Final_Gerald_Castro` ;

-- -----------------------------------------------------
-- Table `Proyecto_Final_Gerald_Castro`.`Vendedor`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto_Final_Gerald_Castro`.`Vendedor` (
  `Cedula_Vende` VARCHAR(25) NOT NULL ,
  `Nom_Vende` VARCHAR(25) NOT NULL ,
  `Direccion_Vende` VARCHAR(50) NOT NULL ,
  `Telefono_Vende` INT NOT NULL ,
  `Contra_Vende` VARCHAR(8) NOT NULL ,
  `Pregunta_Vende` VARCHAR(30) NOT NULL ,
  `Respuesta_Vende` VARCHAR(25) NOT NULL ,
  PRIMARY KEY (`Cedula_Vende`) ,
  UNIQUE INDEX `Cedula_Vende_UNIQUE` (`Cedula_Vende` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_Final_Gerald_Castro`.`Cliente`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto_Final_Gerald_Castro`.`Cliente` (
  `Cedula_Cliente` VARCHAR(25) NOT NULL ,
  `Nom_Cliente` VARCHAR(25) NOT NULL ,
  `DomiciFisico_Cliente` VARCHAR(40) NOT NULL ,
  `Telefono1_Cliente` INT NOT NULL ,
  `Telefono2_Cliente` INT NULL ,
  `CodigoPostal_Cliente` INT NOT NULL ,
  `Correo_Cliente` VARCHAR(50) NOT NULL ,
  `DomicilioFiscal_Cliente` VARCHAR(40) NOT NULL ,
  PRIMARY KEY (`Cedula_Cliente`) ,
  UNIQUE INDEX `Cedula_Cliente_UNIQUE` (`Cedula_Cliente` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_Final_Gerald_Castro`.`Producto`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto_Final_Gerald_Castro`.`Producto` (
  `Id_Producto` INT NOT NULL ,
  `Descrip_Producto` VARCHAR(50) NOT NULL ,
  `Cantidad_Producto` INT NOT NULL ,
  `Proveedor1_Producto` VARCHAR(25) NOT NULL ,
  `Proveedor2_Producto` VARCHAR(25) NULL ,
  `Precio_sin_iva_Producto` DECIMAL(10) NOT NULL ,
  `Iva_Producto` VARCHAR(10) NOT NULL ,
  `Precio_con_iva_Producto` DECIMAL(10) NOT NULL ,
  PRIMARY KEY (`Id_Producto`) ,
  UNIQUE INDEX `Id_Producto_UNIQUE` (`Id_Producto` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_Final_Gerald_Castro`.`Factura`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto_Final_Gerald_Castro`.`Factura` (
  `Numero_Factura` INT NOT NULL ,
  `Vendedor_Factura` VARCHAR(25) NOT NULL ,
  `Fecha_Factura` DATETIME NOT NULL ,
  `Cedula_Cliente_Factura` VARCHAR(25) NOT NULL ,
  `TipoFactura_Factura` VARCHAR(25) NOT NULL DEFAULT 'Contado' ,
  `TipoPago_Factura` VARCHAR(25) NOT NULL DEFAULT 'Efectivo' ,
  `SubTotal_Factura` DECIMAL(10) NOT NULL ,
  `Descuento_Factura` VARCHAR(10) NOT NULL ,
  `Total_Factura` DECIMAL(10) NOT NULL ,
  PRIMARY KEY (`Numero_Factura`) ,
  UNIQUE INDEX `Numero_Factura_UNIQUE` (`Numero_Factura` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto_Final_Gerald_Castro`.`DetalleFactura`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto_Final_Gerald_Castro`.`DetalleFactura` (
  `NumeroFactura_DetalleFactura` INT NOT NULL ,
  `IdProducto_DetalleFactura` INT NOT NULL ,
  `DescripProdu_DetalleFactura` VARCHAR(50) NOT NULL ,
  `Cantidad_DetalleFactura` INT NOT NULL ,
  `PrecioProdu_DetalleFactura` DECIMAL(10) NOT NULL ,
  `SubTot_DetalleFactura` DECIMAL(10) NOT NULL )
ENGINE = InnoDB;

USE `Proyecto_Final_Gerald_Castro` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
