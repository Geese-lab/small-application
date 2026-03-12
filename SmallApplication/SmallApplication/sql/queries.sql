-- select users
SELECT * FROM users;

-- join
SELECT u.name, o.total
FROM users u
JOIN orders o ON u.id = o.user_id;

-- where
SELECT * FROM orders
WHERE total > 100;

-- group by + aggregate
SELECT user_id, COUNT(*) AS order_count
FROM orders
GROUP BY user_id;