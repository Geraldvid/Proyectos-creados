SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

ALTER TABLE `Proyecto_Final_Gerald_Castro`.`Factura` 
  ADD CONSTRAINT `Cedula_Vendedor_FK`
  FOREIGN KEY (`Vendedor_Factura` )
  REFERENCES `Proyecto_Final_Gerald_Castro`.`Vendedor` (`Cedula_Vende` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION, 
  ADD CONSTRAINT `Cedula_Cliente_FK`
  FOREIGN KEY (`Cedula_Cliente_Factura` )
  REFERENCES `Proyecto_Final_Gerald_Castro`.`Cliente` (`Cedula_Cliente` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION
, ADD INDEX `Cedula_Vendedor_FK_idx` (`Vendedor_Factura` ASC) 
, ADD INDEX `Cedula_Cliente_FK_idx` (`Cedula_Cliente_Factura` ASC) ;

ALTER TABLE `Proyecto_Final_Gerald_Castro`.`DetalleFactura` 
  ADD CONSTRAINT `Numero_Factura_FK`
  FOREIGN KEY (`NumeroFactura_DetalleFactura` )
  REFERENCES `Proyecto_Final_Gerald_Castro`.`Factura` (`Numero_Factura` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION, 
  ADD CONSTRAINT `Id_Producto_FK`
  FOREIGN KEY (`IdProducto_DetalleFactura` )
  REFERENCES `Proyecto_Final_Gerald_Castro`.`Producto` (`Id_Producto` )
  ON DELETE NO ACTION
  ON UPDATE NO ACTION
, ADD INDEX `Numero_Factura_FK_idx` (`NumeroFactura_DetalleFactura` ASC) 
, ADD INDEX `Id_Producto_FK_idx` (`IdProducto_DetalleFactura` ASC) ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
