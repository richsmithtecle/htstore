--DROP TABLE products;
--DROP TABLE categories;

CREATE TABLE categories
(
	id		int				identity(1,1),
	name	varchar(100)	not null,

	constraint pk_categories primary key (id)
);

CREATE TABLE products
(
	id					int				identity(1,1),
	manufacturer		varchar(255)	not null,
	model_number		varchar(255)	not null,
	price				decimal			not null,
	short_description	varchar(max)	not null,
	long_description	varchar(max)	not null,
	category_id			int,
	image				varchar(255)	not null,

	constraint pk_products primary key (id),
	constraint fk_products_categories foreign key (category_id) references categories(id)
);

insert into categories (name) VALUES ('TV');
insert into categories (name) VALUES ('Audio');
insert into categories (name) VALUES ('Video');
insert into categories (name) VALUES ('Furniture');
insert into categories (name) VALUES ('Sonos');


--insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Radish', '1.42', 'A really tasty Radish - Pickled perfect for a picnic.', 3, 'http://dummyimage.com/250x250.png/5fa2dd/ffffff');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR55X850E', '899.99', '1', '55" 4K Ultra HD TV', 'Add Lorum Ipsum text here', 'XBR55X850E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR55X900E', '1199.99', '1', '55" 4K Ultra HD TV', 'Add Lorum Ipsum text here', 'XBR55X900E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR55X930E', '1499.99', '1', '55" 4K Ultra HD TV', 'Add Lorum Ipsum text here', 'XBR55X930E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR55A1E', '2499.99', '1', '55" 4K Ultra OLED TV', 'Add Lorum Ipsum text here', 'XBR55A1E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR65X850E', '1499.99', '1', '65" 4K Ultra HD TV', 'Add Lorum Ipsum text here', 'XBR55X850E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR65X900E', '1999.99', '1', '65" 4K Ultra HD TV', 'Add Lorum Ipsum text here', 'XBR55X900E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR65X930E', '2499.99', '1', '65" 4K Ultra HD TV', 'Add Lorum Ipsum text here', 'XBR55X930E.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'XBR65A1E', '3999.99', '1', '65" 4K Ultra OLED TV', 'Add Lorum Ipsum text here', 'XBR55A1E.jpg');


insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Denon', 'AVRX1300', '499.99', '2', '80-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'AVRX1300.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Denon', 'AVRX2300', '699.99', '2', '90-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'AVRX2300.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Denon', 'AVRX3300', '999.99', '2', '100-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'AVRX3300.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Denon', 'AVRX4300', '1499.99', '2', '125-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'AVRX4300.jpg');

insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sonos', 'PLAY1', '199.99', '5', 'Wi-Fi Speaker', 'Add Lorum Ipsum text here', 'PLAY1.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sonos', 'PLAY3', '299.99', '5', 'Wi-Fi Speaker', 'Add Lorum Ipsum text here', 'PLAY3.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sonos', 'PLAY5', '499.99', '5', 'Wi-Fi Speaker', 'Add Lorum Ipsum text here', 'PLAY5.jpg');

insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Ashley', 'W319-28', '399.99', '4', '50-inch Wide TV Stand', 'Add Lorum Ipsum text here', 'W319-28.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Ashley', 'W319-38', '499.99', '4', '60-inch Wide TV Stand', 'Add Lorum Ipsum text here', 'W319-38.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Ashley', 'W319-48', '599.99', '4', '65-inch Wide TV Stand', 'Add Lorum Ipsum text here', 'W319-48.jpg');

UPDATE products SET image = 'PLAY5.png' WHERE image = 'PLAY5.jpg'
select * from products where category_id = '2'
select * from categories

insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'STRZA1000ES', '499.99', '2', '80-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'STRZA1000ES.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'STRZA2000ES', '699.99', '2', '90-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'STRZA2000ES.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'STRZA3000ES', '999.99', '2', '100-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'STRZA3000ES.jpg');
insert into products (manufacturer, model_number, price, category_id, short_description, long_description, image) values ('Sony', 'STRZA5000ES', '1499.99', '2', '125-watt Home Theater Receiver', 'Add Lorum Ipsum text here', 'STRZA5000ES.jpg');

ALTER TABLE products ALTER COLUMN price money;
ALTER TABLE products ALTER COLUMN price decimal(16,2);